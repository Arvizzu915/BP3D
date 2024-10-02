using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    [SerializeField] public int ballsToWin;

    private void Update()
    {
        if (ballsToWin <= 0) 
        {
            Debug.Log("win");
        }
    }
}
