using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{

    Animator animator;
    Animator headAnim;

    PlayerInput input;

    CharacterController characterController;

    int isWalkingHash;
    int raiseHandHash;
    int sitHash;
    int clapHash;

    int interactionsLayerIndex;

    bool isWalking;
    bool isRaisingHand;
    bool isSitting;
    bool isClapping;

    Vector2 currentMovementInput;
    Vector3 currentMovement;
    bool isMovementPressed;

    bool raiseHandInput;
    bool sitInput;
    bool standInput;
    bool clapInput;

    float rotationFactorPerFrame = 10f;

    float characterControllerY = 0.5f;


    void Awake()
    {
        input = new PlayerInput();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        interactionsLayerIndex = animator.GetLayerIndex("Interactions");
        isWalkingHash = Animator.StringToHash("isWalking");
        raiseHandHash = Animator.StringToHash("raiseHand");
        sitHash = Animator.StringToHash("isSitting");
        clapHash = Animator.StringToHash("isClapping");


        //GameObject head = transform.Find("head(Clone)").gameObject;
        //headAnim = GetComponentInChildren<Animator>();


        input.CharacterMovement.Movement.started += onMovementInput;
        input.CharacterMovement.Movement.performed += onMovementInput;
        input.CharacterMovement.Movement.canceled += onMovementInput;

        input.Interactions.RaiseHand.started += onRaiseHandInput;
        input.Interactions.RaiseHand.performed += onRaiseHandInput;
        input.Interactions.RaiseHand.canceled += onRaiseHandInput;

        input.Interactions.Sit.started += onSitInput;
        input.Interactions.Sit.performed += onSitInput;
        input.Interactions.Sit.canceled += onSitInput;

        input.Interactions.Stand.performed += onStandInput;

        input.Interactions.Clap.started += onClapInput;
        input.Interactions.Clap.performed += onClapInput;
        input.Interactions.Clap.canceled += onClapInput;
    }

    void onMovementInput(InputAction.CallbackContext ctx)
    {
        currentMovementInput = ctx.ReadValue<Vector2>();
        if (!isSitting)
        {
            currentMovement.x = currentMovementInput.x;
            currentMovement.z = currentMovementInput.y;
        }
        
        
    }
    void onSitInput(InputAction.CallbackContext ctx)
    {
        sitInput = ctx.ReadValueAsButton();

        float radius = 0.5f;
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius, ~0, QueryTriggerInteraction.Collide);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].CompareTag("Chair"))
            {
                // Do something with the object
                Debug.Log("Chair found: " + hitColliders[i].gameObject.name);
                // Move the player to the chair position
                transform.position = hitColliders[i].transform.position + new Vector3(0, 0, 0.2f);
                transform.rotation = hitColliders[i].transform.rotation;
                transform.Rotate(90, 0, 0);
                if(sitInput && !isWalking && !isRaisingHand)
                {
                    animator.SetBool(sitHash, true);
                    characterController.center = new Vector3(0,characterControllerY, 0.36f);
                }
            }
        }

        if (headAnim)
        {
            headAnim.CrossFade(sitHash, 0.1f);
        }
        
        

        
    }
    void onStandInput(InputAction.CallbackContext ctx)
    {
        
        standInput = ctx.ReadValueAsButton();
        if(standInput && isSitting)
        {
            animator.SetBool(sitHash, false);
            Invoke("resetCharacterControllerCenter", 1.5f);
        }
    }

    void resetCharacterControllerCenter()
    {
        characterController.center = new Vector3(0, characterControllerY, 0f);
    }

    void onRaiseHandInput(InputAction.CallbackContext ctx)
    {
        //AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        //float NormTime = animatorStateInfo.normalizedTime;
        isRaisingHand = animator.GetBool(raiseHandHash);
        raiseHandInput = ctx.ReadValueAsButton();
        if(raiseHandInput && !isRaisingHand && !isWalking)
        {
            animator.SetBool(raiseHandHash, true);
            Invoke("stopRaisingHand", 1);
        }
    }

    void stopRaisingHand()
    {
        animator.SetBool(raiseHandHash, false);
    }
    void onClapInput(InputAction.CallbackContext ctx)
    {
        clapInput = ctx.ReadValueAsButton();
        if(clapInput && !isRaisingHand && !isWalking)
        {
            animator.SetBool(clapHash, true);
            Invoke("stopClapping", 1);
        }
    }

    void stopClapping()
    {
        animator.SetBool(clapHash, false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    void handleWalking()
    {
        if (isMovementPressed && !isWalking && !isSitting)
        {
            animator.SetBool(isWalkingHash, true);
        } else if(!isMovementPressed && isWalking) {
            animator.SetBool(isWalkingHash, false);
        }
    }

    void handleRotation()
    {
        if (!isSitting)
        {
            Vector3 positionToLookAt;
            positionToLookAt.x = currentMovement.x;
            positionToLookAt.z = currentMovement.z;
            positionToLookAt.y = 0.0f; // no rotation

            Quaternion currentRotation = transform.rotation;

            if(isMovementPressed)
            {
                Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
                transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotationFactorPerFrame * Time.deltaTime);
                //Debug.Log("rotating, is sitting : " + isSitting);
            }
        }
        
    }

    void handleGravity()
    {
        if (characterController.isGrounded)
        {
            float groundedGrav = -0.05f;
            currentMovement.y = groundedGrav;

            //characterController.Move(currentMovement * Time.deltaTime);
        } else
        {
            float gravity = -9.8f;
            currentMovement.y = gravity;

            characterController.Move(currentMovement * Time.deltaTime);
        }
    }

    void updateParameters()
    {
        isSitting = animator.GetBool(sitHash);
        isWalking = animator.GetBool(isWalkingHash);
        isMovementPressed = currentMovement.x != 0 || currentMovement.z != 0;
        isRaisingHand = animator.GetBool(raiseHandHash);
        isClapping = animator.GetBool(clapHash);
    }
    // Update is called once per frame
    void Update()
    {
        /*
        float speed = 10f;
        if (characterController.isGrounded)
        {
            Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            characterController.Move(moveDirection * Time.deltaTime);
        }
        else
        {
            characterController.Move(Physics.gravity * Time.deltaTime);
        }
        */
        //Debug.Log(isSitting);

        updateParameters();
        handleWalking();
        handleRotation();
        handleGravity();
        //characterController.Move(currentMovement * Time.deltaTime);

    }



     void OnEnable()
    {
        input.Enable();
        characterController.enabled = true;
    }

     void OnDisable()
    {
        input.Disable();
    }

}
