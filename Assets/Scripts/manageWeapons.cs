using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageWeapons : MonoBehaviour
{
    [SerializeField] GameObject w1, w2, w3;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            w1.SetActive(false);
            w2.SetActive(false);
            w3.SetActive(false);
        }
        else
        {
            w1.SetActive(true);
            w2.SetActive(true);
            w3.SetActive(true);
        }
    }
}
