using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [Header("MenuReferns")]
    public GameObject FinishMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        FinishMenu.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Car"))
        {
            Debug.Log("Finish");
            enableMenu();
        }
    }
    private void enableMenu()
    {
        Time.timeScale = 0;
        FinishMenu.SetActive(true);
    }
}
