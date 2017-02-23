using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void newScene()
    {

    }
    public void onClick()
    {
        //starts new game
        UnityEngine.SceneManagement.SceneManager.LoadScene("sceneMain");

    }
}
