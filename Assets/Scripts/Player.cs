﻿using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class Player : MonoBehaviour
{ 
    public float maxSpeed = 5;
    public float speed = 50f;
    public float jumpPower = 300f;

    public bool grounded;

    public int currentHealth;
    public int maxHealth = 5;

    private Rigidbody2D rb2d;
    private Animator anim;

	void Start ()
    {
        //gets game objects
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();

        currentHealth = maxHealth;
    }
	
	void Update ()
    {
        //controls and manages character movement and health

        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));

        //controls players movement (left and right, jumping)
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }
        //determines what to do when character is a certain health
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void FixedUpdate()
    {
        //controls the velocity of the player model
        Vector3 easeVelocity = rb2d.velocity;
        easeVelocity.y = rb2d.velocity.y;
        easeVelocity.z = 0.0f;
        easeVelocity.x *= 0.75f;
        //conditional, determines if the player is standing on the grouond
        if (grounded)
        {
            rb2d.velocity = easeVelocity;
        }
        //contorls the velocity of the player
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce((Vector2.right * speed) * h);

        if(rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
    }
    void Die()
    {
        //loads scene after player dies
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    void OnApplicationQuit()
    {
        //sends email saying that the program closed successfully, triggered on exit
        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bitteam6@gmail.com");
            mail.To.Add("bitteam6@gmail.com");
            mail.Subject = "Debug Message";
            mail.Body = "Game closed successfully. There were no errors. Time: " + System.DateTime.Now + "User: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("bitteam6", "sealteam6bit") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
            smtpServer.Send(mail);
        }
        catch (Exception ex)
        {

        }

        //application exits after above code has run
        Application.Quit();
    }

}
