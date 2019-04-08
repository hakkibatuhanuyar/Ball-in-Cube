using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//-------------------TIMER TEXT CODE-------------------//


public class timertext : MonoBehaviour {

    public Text Timer;

    private float Starttime;

    public int milliseconds;

    void Start()
    {
        Starttime = Time.time;
    }

    public void Update()
    {

        //milliseconds = (int)(Time.timeSinceLevelLoad * 3600f);

        //string Milli = (milliseconds).ToString("00");

        float t = Time.time - Starttime;

        string Seconds = (t).ToString("f2");

        Timer.text = (Seconds).ToString();

    }

}

