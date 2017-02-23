using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    //Initailze variables
    public Sprite[] HeartSprites;
    public Image HeartUI;
    private Player player;

    private void Start()
    {
        //attach camera to player
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void Update()
    {
        //Set heart sprite to player health
        HeartUI.sprite = HeartSprites[player.currentHealth];
    }
}
