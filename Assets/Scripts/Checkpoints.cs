using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Checkpoints : MonoBehaviour
{
    public TMP_Text Numero; 
    
    public Vector3 check1;
    public Vector3 check2;
    public Vector3 check3;
    
    void Awake()
    {
        if (PlayerPrefs.GetInt("Checkpoints") == 1)
        {
            this.transform.position = check1;
        }

        if (PlayerPrefs.GetInt("Checkpoints") == 2)
        {
            this.transform.position = check2;
        }

        if (PlayerPrefs.GetInt("Checkpoints") == 3)
        {
            this.transform.position = check3;
        }

        Numero.text = " ";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "check1")
        {
            PlayerPrefs.SetInt("Checkpoints", 1);
            Numero.text = "1";
        }

        if (other.gameObject.tag == "check2")
        {
            PlayerPrefs.SetInt("Checkpoints", 2);
            Numero.text = "2";
        }

        if (other.gameObject.tag == "check3")
        {
            PlayerPrefs.SetInt("Checkpoints", 3);
            Numero.text = "3";
        }
    }
}
