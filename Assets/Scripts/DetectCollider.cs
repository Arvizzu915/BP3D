using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    [SerializeField] Ball ballScript;

    private void OnTriggerEnter(Collider other)
    {
        if (!ballScript.moving &&  other.gameObject.CompareTag("Player"))
        {
            HitBall.instance.playerInRange = true;
            ballScript.direction = -transform.localPosition;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HitBall.instance.playerInRange = false;
        }
    }
}
