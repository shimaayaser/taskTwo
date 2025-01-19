using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment37{
public class RigidbodyCharacterScript : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 input;
    bool jump = false;
    float Speed = 5f;
   
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;

    }

   
    void Update()
    {
        
            input = input.normalized * Speed;

            input.y = rigidbody.velocity.y;
            
            input = new Vector3(-Input.GetAxisRaw("Horizontal"),
                                0,
                                -Input.GetAxisRaw("Vertical"));

            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = true;
            }
    }
    void FixedUpdate()
        {
           if (jump)
            {
              
                rigidbody.AddForce(Vector3.up * 15, ForceMode.Impulse);
                jump = false;
            }
            else
            
                rigidbody.velocity = input;
            }
        }
}
}