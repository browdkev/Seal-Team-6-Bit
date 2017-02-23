using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    public GameObject bullet;
    public Vector3 positionRight;

    private void Update()
    {
        positionRight = new Vector3(transform.position.x - .07f, transform.position.y);
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }

    }
    void shoot()
    {
        Instantiate(bullet, positionRight, Quaternion.identity);
    }
}
