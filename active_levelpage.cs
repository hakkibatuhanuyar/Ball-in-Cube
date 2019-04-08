using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class active_levelpage : MonoBehaviour {

    public GameObject[] Levels;
 
    public void Start()
    {

        for (int i = 0; i < PlayerPrefs.GetInt("lastlevel"); i=i+1)
        {

            Levels[0].SetActive(true);

            Levels[i].SetActive(true);

        }

    }

}

