using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CodeyMove : MonoBehaviour
{
    public float Speed = 5f;
    Animator anim;

    public bool running = false;
    public bool canMove = true;


    public float _rotationSpeed = 50f;
 
    void Start()
    {
      
        anim = GetComponent<Animator>();
        
    }
    void Update()
    {

        if (canMove)
        {

            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
           

            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            Vector3 move = Vector3.forward * Speed * Time.deltaTime * vertical;
         
            transform.Rotate(rotation);
            transform.Translate(move);
            if (move != Vector3.zero)
            {
            
                running = true;
            }
            else
            {
                running = false;
            }
            
            anim.SetBool("isRunning", running);
        }

    }
}