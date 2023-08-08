using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameWonUI : MonoBehaviour
{
    public GameObject pauseUiCanvas;
    private bool isPaused = false;


    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1.0f;
    }

    public void pause()
    {
        isPaused = !isPaused;

        if(isPaused)
        {
            pauseUiCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseUiCanvas.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public void Resume()
    {
        if(isPaused)
        {
            pauseUiCanvas.SetActive(false );
            Time.timeScale = 1.0f;
        }
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }


}
    
