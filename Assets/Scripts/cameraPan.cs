using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPan : MonoBehaviour {
    public Animation anim;

    void Start ()
    {
        anim.wrapMode = WrapMode.ClampForever;
        anim.Play("cameraPan.anim");

    }

    // Update is called once per frame
    void Update ()
    {


    }
}
