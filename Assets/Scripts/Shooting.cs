using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Referens")]
    PlayerMovement playerMovement;
    public Transform firePoint;
    public GameObject colabulletPrefab;

    private bool hasPlayerAmmo;
   
    [Header("BulletSettings")]
    public float bulletForce = 20f;
    public float currentAmmo;
    public float maxAmmo;
    
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        currentAmmo = maxAmmo;

    }

    // Update is called once per frame
    void Update()
    {
        #region PlayerFire
         //if player press button its shooting and using hasplayerAmmo.
        if (playerMovement.isPlayerOne)
        {
            if (Input.GetButtonDown("Fire1") && hasPlayerAmmo)
            {
                Debug.Log("PEW1 PEW1");
                Shoot();
            }
            else
            {
                hasPlayerAmmo = false;
            } 
           
        } else if (playerMovement.isPlayerTwo)
        {
            if (Input.GetButtonDown("Fire2") && hasPlayerAmmo)
            {
                Debug.Log("PEW2 PEW2");
                Shoot();
            }
            else
            {
                hasPlayerAmmo = false;
            }

        }

        #endregion

        #region PlayerAmmo
        //checking current ammo
        if (currentAmmo > 0)
        {
            hasPlayerAmmo = true;
        }else if (currentAmmo == 0)
        {
            hasPlayerAmmo = false;
        }
        #endregion 
    }
    void Shoot()
    {
        //Spawning the bullet and get force and the firepoint postion etc.
        GameObject colaBullet = Instantiate(colabulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb2D = colaBullet.GetComponent<Rigidbody2D>();
        rb2D.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        currentAmmo--;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       // if (playerMovement.isPlayerOne) return;
       // if (playerMovement.isPlayerTwo) return;
      
        if (other.gameObject.CompareTag("colaBullet"))
        {
            Debug.Log("carhit");
            StartCoroutine(playerMovement.SlowDown());

        }
    }
}
