using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hak : MonoBehaviour
{

    public static int kalanCan = 3;
    public TextMeshProUGUI can;
    public GameObject bitisPaneli;


    void Start()
    {
        
    }

    
    void Update()
    {
        can.text = "Can: " + kalanCan.ToString();

        if (kalanCan == 0)
        {

            bitisPaneli.SetActive(true);

            Time.timeScale = 0;


        }
    }
}
