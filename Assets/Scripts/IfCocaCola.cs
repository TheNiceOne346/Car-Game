using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCocaCola : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            other.GetComponent<SpriteRenderer>().color = Color.magenta;
            Debug.Log("Easter Egg Works");
        }
        Debug.Log("TEST");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
