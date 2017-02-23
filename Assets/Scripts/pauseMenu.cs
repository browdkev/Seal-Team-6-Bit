using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

    public GameObject PauseUI;

    private bool paused = false;

    private void Start()
    {
        PauseUI.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Resume()
    {
        paused = false;
    }
    public void Restart()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    public void MainMenu()
    {
        //Application.LoadLevel(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
