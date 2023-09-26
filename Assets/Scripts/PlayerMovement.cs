using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
   
    

    public Rigidbody2D rbcar2D;

    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
       // input
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
       
        
        //movement
        rbcar2D.MovePosition(rbcar2D.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
