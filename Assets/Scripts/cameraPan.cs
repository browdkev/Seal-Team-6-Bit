using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPan : MonoBehaviour {
    public Animation anim;
    

    void Start ()
    {
        
        anim.wrapMode = WrapMode.Once;
        anim.Play("cameraPan.anim");
        anim.Play("buttonCanvasAnim.anim");

    }

    // Update is called once per frame
    void Update ()
    {

       //if (anim.IsPlaying("cameraPan.anim") == false)
       // {

       // }

    }
}
