using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    [Header("TextReferens")]
    public TMP_Text countText;

    [Header("Timer")]
    public float countDown = 3;
    public float startTimer;
   

    private void Awake()
    {
        startTimer = countDown;
    }
    

    // Update is called once per frame
    void Update()
    {
        #region StartCountDown
        if (startTimer > 0 ) 
        {
            startTimer -= Time.deltaTime;   
        }

        if ( startTimer <= 0 ) 
        {
            countText.gameObject.SetActive( false );    
        }
        
        #endregion
        
        countText.text = " " + startTimer.ToString("0");

        StartCoroutine(Timer());
    }
    public IEnumerator Timer()
    {
        //using a IEnumerator to make the game frezze each level 3 seconds but 0,5 seconds through every update of numbers
        yield return new WaitForSeconds(0.5f);

    }
}
