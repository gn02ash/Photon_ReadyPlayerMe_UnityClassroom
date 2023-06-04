using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    // [SerializeField] float movementSpeed = 6f;
    // [SerializeField] float jumpForce = 5f;

    // [SerializeField] Transform groundCheck;
    // [SerializeField] LayerMask ground;

    // [SerializeField] AudioSource jumpSound;

    float speed = 40f;
    // float rotationSpeed = 720f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow)){
          
          rb.transform.Translate(Vector3.forward * Time.deltaTime * speed);
          // rb.transform.Rotate(0, 0, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){

          
          rb.transform.Translate(Vector3.back * Time.deltaTime * speed);
          // rb.transform.Rotate(0, rb.transform.localRotation.y + 180, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
          
          rb.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
          rb.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        // if (rb.transform.localPosition != Vector3.zero)
        // {

        //   transform.forward = rb.transform.localPosition;
        //     // Quaternion toRotation = Quaternion.LookRotation(rb.transform.localPosition, Vector3.up);
        //     // transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);            
        // }
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");

        // rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        // if (Input.GetKey("up"))
        // {
        //     rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        // }
    }
    // void Jump()
    // {
    //     rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    //     jumpSound.Play();
    // }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Enemy Head"))
    //     {
    //         Destroy(collision.transform.parent.gameObject);
    //         Jump();
    //     }
    // }

    // bool IsGrounded()
    // {
    //     return Physics.CheckSphere(groundCheck.position, .1f, ground);
    // }
}
