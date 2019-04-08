using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class besttime : MonoBehaviour {

    public Text Timer;

    private float Starttime;

    public GameObject Nextmenu;

    //private void Awake() { PlayerPrefs.DeleteAll(); }

    void Start()
    {
        Starttime = Time.time;
    }

    public void Update()
    {

        float t = Time.time - Starttime;

        string Seconds = (t).ToString("f2");

        float Besttime = (t);

        Timer.text = PlayerPrefs.GetFloat("Besttime"+ SceneManager.GetActiveScene().buildIndex).ToString("f2");

        if (Nextmenu.activeSelf)
        {
            if (Besttime < PlayerPrefs.GetFloat("Besttime"+ SceneManager.GetActiveScene().buildIndex) || PlayerPrefs.GetFloat("Besttime"+ SceneManager.GetActiveScene().buildIndex) == 0)
            {

                Timer.text = Seconds;

                PlayerPrefs.SetFloat("Besttime"+ SceneManager.GetActiveScene().buildIndex, Besttime);

            }
            if (Besttime > PlayerPrefs.GetFloat("Besttime"+ SceneManager.GetActiveScene().buildIndex))
            {

                Timer.text = PlayerPrefs.GetFloat("Besttime"+ SceneManager.GetActiveScene().buildIndex).ToString("f2");

            }

        }

    }

}

