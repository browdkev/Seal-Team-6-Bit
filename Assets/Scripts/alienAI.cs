﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienAI : MonoBehaviour
{
    //Initilize variable
    public int currentHealth;
    public int maxHealth;

    public float distance;
    public float wakeRange;
    public float shootInterval;
    public float bulletSpeed = 100;
    public float bulletTimer;

    public GameObject bullet;
    public Transform target;
    public Animator anim;
    public Transform shootPointLeft;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        rangeCheck();
    }
    void rangeCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

    }
    /// <summary>
    /// Method spawns bullets and sends them in the players direction
    /// </summary>
    public void Attack()
    {
        bulletTimer += Time.deltaTime;
        
        if(bulletTimer >= shootInterval)
        {
            //Sets direction of bullet
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            GameObject bulletClone;
            //Clones bullets
            bulletClone = Instantiate(bullet, shootPointLeft.transform.position, shootPointLeft.transform.rotation) as GameObject;
            bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

            bulletTimer = 0;
        } 
    }
}
