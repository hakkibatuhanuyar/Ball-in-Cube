using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//----------------CODE TO RUN ON NEXT LEVEL BUTTON----------------//

public class nextlevelbutton : MonoBehaviour {
    
    public void Nexttt()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        Time.timeScale = 1;

    }
}
