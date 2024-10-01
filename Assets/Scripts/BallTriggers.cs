using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTriggers : MonoBehaviour
{
    [SerializeField] Ball ballScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DirPad"))
        {
            ballScript.direction = other.gameObject.GetComponent<DirPads>().direction;
        }
    }
}
