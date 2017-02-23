using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick()
    {
        //starts new game
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");

    }
}
