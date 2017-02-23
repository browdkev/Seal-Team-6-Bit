using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCone : MonoBehaviour {
    //Checking cone for player
    public alienAI alienAI;

    private void Awake()
    {
        alienAI = gameObject.GetComponentInParent<alienAI>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            alienAI.Attack();
        }
    }
}
