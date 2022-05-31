using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenidenoyna : MonoBehaviour
{
    
    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        hak.kalanCan = 3;
        Time.timeScale = 1;
        


    }

    
}
