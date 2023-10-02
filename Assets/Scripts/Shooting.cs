using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject colabulletPrefab;
    PlayerMovement playerMovement;

    public float bulletForce = 20f;
    private void Awake()
    {
        playerMovement = FindFirstObjectByType<PlayerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isPlayerOne)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            } 
           
        } else if (playerMovement.isPlayerTwo)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                Shoot();
            } 

        }


        void Shoot()
        {
            GameObject colaBullet = Instantiate(colabulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb2D = colaBullet.GetComponent<Rigidbody2D>();
            rb2D.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
