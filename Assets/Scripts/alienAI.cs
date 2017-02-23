using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienAI : MonoBehaviour
{
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
        if(distance <= wakeRange)
        {

        }
        if(distance >= wakeRange)
        {

        }

    }
    public void Attack()
    {
        bulletTimer += Time.deltaTime;
        
        if(bulletTimer >= shootInterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            Object bulletClone;

            bulletClone = Instantiate(bullet, shootPointLeft.transform.position, shootPointLeft.transform.rotation) as GameObject;
        } 
    }
}
