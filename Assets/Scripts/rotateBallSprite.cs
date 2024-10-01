using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBallSprite : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;

    [SerializeField] private Ball ballScript;

    private void Update()
    {
        if (ballScript.moving) 
        {
            transform.Rotate(ballScript.direction.z * rotateSpeed * Time.deltaTime, 0f, ballScript.direction.x * rotateSpeed * Time.deltaTime);
        }
    }
}
