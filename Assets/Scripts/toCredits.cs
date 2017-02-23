using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
<<<<<<< HEAD
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SceneCredits");
=======
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
>>>>>>> origin/master
    }
}
