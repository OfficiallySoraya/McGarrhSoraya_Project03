using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterController controller;
    
    public Transform cam;

public float verticalVelocity;
    public float gravity = 14.0f;
    public float jumpForce = 10.0f;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    
    }



    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
         

        if(direction.magnitude >= 0.1f)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);


            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }


        if(controller.isGrounded)
           {
               verticalVelocity = -gravity * Time.deltaTime;
               if(Input.GetKey(KeyCode.Space))
               {
                   verticalVelocity = jumpForce;
               }
           }
           else
           {
               verticalVelocity -= gravity * Time.deltaTime;
           }

           Vector3 moveVector = new Vector3(0,verticalVelocity,0);
           controller.Move(moveVector * Time.deltaTime);
    }
}
