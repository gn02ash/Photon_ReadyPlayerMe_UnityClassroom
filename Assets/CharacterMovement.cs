using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{

    Animator animator;

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
        currentMovement.x = currentMovementInput.x;
        currentMovement.z = currentMovementInput.y;
        
    }
    void onSitInput(InputAction.CallbackContext ctx)
    {
        
        sitInput = ctx.ReadValueAsButton();
        if(sitInput && !isWalking && !isRaisingHand)
        {
            animator.SetBool(sitHash, true);
        }
    }
    void onStandInput(InputAction.CallbackContext ctx)
    {
        
        standInput = ctx.ReadValueAsButton();
        if(standInput && isSitting)
        {
            animator.SetBool(sitHash, false);
        }
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
                Debug.Log("rotating, is sitting : " + isSitting);
            }
        }
        
    }

    void handleGravity()
    {
        if (characterController.isGrounded)
        {
            float groundedGrav = -0.05f;
            currentMovement.y = groundedGrav;
        } else
        {
            float gravity = -9.8f;
            currentMovement.y = gravity;
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
        updateParameters();
        handleWalking();
        handleRotation();
        handleGravity();
        //characterController.Move(currentMovement * Time.deltaTime);

    }



     void OnEnable()
    {
        input.Enable();
    }

     void OnDisable()
    {
        input.Disable();
    }

}
