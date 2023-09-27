using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerSettings")]
    [SerializeField]
    public float moveSpeed = 5f;
    [Space]
    
    [Header("WhichPlayer")]
    public bool isPlayerOne;
    public bool isPlayerTwo;
    
    [Header("Rotation")]
    [SerializeField] 
    public float rotationSpeed;
    public Rigidbody2D rbcar2D;

    private Vector2 movement;

    public IEnumerator Timer()
    {
        
        yield return new WaitForSeconds(2.0f);
        
    }

    private void FixedUpdate()
    {
        //movement
        rbcar2D.MovePosition(rbcar2D.position + moveSpeed * Time.fixedDeltaTime * movement);

    }
    
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Timer());
        #region SelectPlayers

        // input
        if (isPlayerOne)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            movement.Normalize();
       
            // rotating player depending on movement direction
            if (movement != Vector2.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movement);
                transform.rotation = 
                    Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
            
        }else if (isPlayerTwo)
        {
            movement.x = Input.GetAxisRaw("HorizontalSecond");
            movement.y = Input.GetAxisRaw("VerticalSecond");
            
            if (movement != Vector2.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movement);
                transform.rotation = 
                    Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
            
        }

        #endregion
        
        
    }

    
}
