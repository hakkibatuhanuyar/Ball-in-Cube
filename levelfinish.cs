using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;


public class levelfinish : MonoBehaviour {

    #region PUBLIC_VAR
    public string leaderboard; //buraya tablo kimliğini tanımlamanız gerekiyor.
    #endregion
    #region DEFAULT_UNITY_CALLBACKS

    public GameObject Nextlevelmenu;

    public GameObject Pausebutton;

    public GameObject Leveltext;

    public GameObject Ball;

    public GameObject Cubes;

    public int milliseconds;

    public void Start()
    {

        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();

    }
    #endregion

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

        if (Social.localUser.authenticated)
        {
            Social.ReportScore(milliseconds, leaderboard, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Score Success");
                }
                else
                {
                    Debug.Log("Update Score Fail");
                }
            });
        }


    }

    public void Update()
    {

        milliseconds = (int)(Time.timeSinceLevelLoad * 6f);

    }

}


