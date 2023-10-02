using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if gameobject with tag Car collides with a object load next scene.
        if (other.gameObject.CompareTag("Car"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Debug.Log("NextLevel");
       
    }
}
