using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTriggers : MonoBehaviour
{
    [SerializeField] BoxCollider ballCollider;
    [SerializeField] Ball ballScript;

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
    }
}
