using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitBall : MonoBehaviour
{
    [SerializeField] List<Ball> balls = new List<Ball>();
    [SerializeField] public Ball ballScript;

    public bool playerInRange = false;

    public static HitBall instance;

    private void Awake()
    {
        instance = this;
    }

    public void Hit(InputAction.CallbackContext callbackContext)
    {
        if (playerInRange && callbackContext.performed)
        {
            foreach (Ball ball in balls) 
            {
                ball.ballIndex = 0;
            }
            ballScript.ballIndex = 1;
            ballScript.moving = true;
        }
    }

}
