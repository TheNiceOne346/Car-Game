using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Shooting shooting;
   
    private void Start()
    {
        shooting = GetComponent<Shooting>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If pickup finds tag car then set current ammo to max ammo then destroy game object.
        if (other.gameObject.CompareTag("Car"))
        {
            other.gameObject.GetComponent<Shooting>().currentAmmo = 
            other.gameObject.GetComponent<Shooting>().maxAmmo;
            Debug.Log("maxammo");
            Destroy(gameObject);
        }
    }
}
