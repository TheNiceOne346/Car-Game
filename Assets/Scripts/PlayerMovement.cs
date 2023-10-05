using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerSettings")] [SerializeField]
    public float moveSpeed;

    [Space] [Header("WhichPlayer")] public bool isPlayerOne;
    public bool isPlayerTwo;

    [Header("Rotation")] [SerializeField] public float rotationSpeed;
    public Rigidbody2D rbcar2D;

    private Vector2 movement;
    CountDown countDown;
    public bool slowDown;

    public void Awake()
    {
        countDown = FindFirstObjectByType<CountDown>();
    }

    private void FixedUpdate()
    {
        //movement
        rbcar2D.MovePosition(rbcar2D.position + moveSpeed * Time.fixedDeltaTime * movement);

        //rbcar2D.velocity = transform.forward * movement.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Countdown when player gets hit the movespeed moves from 3 to 5 or reverse
        if (countDown.startTimer > 0)
        {
            moveSpeed = 0;
        }
        else if (countDown.startTimer <= 0)
        {
            if (slowDown)
            {
                moveSpeed = 3;
            }
            else
            {
                moveSpeed = 5;
            }
        }

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
        }
        else if (isPlayerTwo)
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
    public IEnumerator SlowDown()
    {
        // IEnumerator created to slow down the player for 2 seconds.
        slowDown = true;
        yield return new WaitForSeconds(2);
        slowDown = false;
    }
}