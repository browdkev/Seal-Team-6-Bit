using System;
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

public class pauseMenu : MonoBehaviour {

    public GameObject PauseUI;

    private bool paused = false;

    private void Start()
    {
        PauseUI.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Resume()
    {
        paused = false;
    }
    public void Restart()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    public void MainMenu()
    {
        //Application.LoadLevel(1);
    }
    public void Quit()
    {
        //sends email saying that the program closed successfully, triggered on exit
        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bitteam6@gmail.com");
            mail.To.Add("bitteam6@gmail.com");
            mail.Subject = "Debug Message";
            mail.Body = "Game closed successfully. There were no errors. Time: " + System.DateTime.Now;

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


        Application.Quit();
    }
}
