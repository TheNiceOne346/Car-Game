using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public TMP_Text countText;

    public float countDown = 3;
    public float startTimer;
   

    private void Awake()
    {
        startTimer = countDown;
    }

    public IEnumerator Timer()
    {

        yield return new WaitForSeconds(0.5f);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer > 0 ) 
        {
            startTimer -= Time.deltaTime;   
        }

        if ( startTimer <= 0 ) 
        {
            countText.gameObject.SetActive( false );    
        }
        

        countText.text = " " + startTimer.ToString("0");

        StartCoroutine(Timer());
    }
}
