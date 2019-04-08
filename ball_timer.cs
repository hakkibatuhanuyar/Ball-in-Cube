using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball_timer : MonoBehaviour
{
    public float Finishtime;

    private float Starttime;

    void Start()
    {

        Starttime = Time.time;

    }

    public void Update()
    {

        float t = Time.time - Starttime;

        float Seconds = t % 60;

        if (Seconds > Finishtime)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }

}
