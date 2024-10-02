using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTriggers : MonoBehaviour
{
    [SerializeField] BoxCollider ballCollider;
    [SerializeField] Ball ballScript;
    [SerializeField] WinLevel winLevel;
    [SerializeField] Player playerScript;

    [SerializeField] private bool ball;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            ballCollider.enabled = false;
            ballScript.moving = false;
        }

        if (other.gameObject.CompareTag("DirPad"))
        {
            ballScript.direction = other.gameObject.GetComponent<DirPads>().direction;
            ballScript.RoundPosition();
        }

        if (other.gameObject.CompareTag("Void"))
        {
            if(ball) 
            {
                winLevel.ballsToWin--;
            }
            else
            {
                playerScript.ResetLevel();
            }
            gameObject.SetActive(false);
        }
    }
}
