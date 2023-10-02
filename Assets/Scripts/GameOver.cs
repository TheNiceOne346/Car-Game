using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverMenu : MonoBehaviour
{
    public void OnPressRetry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void OnMainMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("MainMenu");
    }

}
