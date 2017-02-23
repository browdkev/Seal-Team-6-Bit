using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Adds force to the bullet from the player
/// </summary>
public class addForce : MonoBehaviour {
    public int speed;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start ()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        rb2d.AddForce(Vector3.right * speed);
	}
}
