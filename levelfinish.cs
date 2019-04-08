using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;


//-------------------CODE TO COMPLETE THE LEVEL-------------------//


public class levelfinish : MonoBehaviour {

    public GameObject Nextlevelmenu;

    public GameObject Pausebutton;

    public GameObject Leveltext;

    public GameObject Ball;

    public GameObject Cubes;

    public int milliseconds;

    public void Start()
    {

    }

    public void OnTriggerExit(Collider Exitpart)
    {
        if (Exitpart.gameObject.name == "exitarea")
        {

            if (PlayerPrefs.GetInt("lastlevel") > SceneManager.GetActiveScene().buildIndex)
            {

                Nextlevelmenu.SetActive(true);

                Pausebutton.SetActive(false);

                Leveltext.SetActive(false);

                Ball.SetActive(false);

                Cubes.SetActive(false);

                Time.timeScale = 0;

                Physics.gravity = new Vector3(0, -9.81f, 0);

            }
            else
            {

                Nextlevelmenu.SetActive(true);

                Pausebutton.SetActive(false);

                Leveltext.SetActive(false);

                Ball.SetActive(false);

                Cubes.SetActive(false);

                Time.timeScale = 0;

                PlayerPrefs.SetInt("lastlevel", SceneManager.GetActiveScene().buildIndex + 1);

                Physics.gravity = new Vector3(0, -9.81f, 0);

            }

        }

    }

    public void Update()
    {

        milliseconds = (int)(Time.timeSinceLevelLoad * 6f);

    }

}


