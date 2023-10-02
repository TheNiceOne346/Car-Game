using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Pause")]
    public GameObject pauseMenu;
    public bool gamepause;


    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC");
            TogglePause();        
        } 
    }

    private void TogglePause()
    {
        // Checking if gamepause is true , if true set time scale to 0 else 1
        gamepause = !gamepause;
        Time.timeScale = gamepause ? 0 : 1;
        pauseMenu.gameObject.SetActive(gamepause);
    }

}
