using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    [SerializeField]
    private float distancebeforedestroy;
    
    // Start is called before the first frame update
    void Start()
    {
     Destroy(gameObject, distancebeforedestroy);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
