using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitBall : MonoBehaviour
{
    [SerializeField] Ball ballScript;

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
            ballScript.moving = true;
        }
    }

}
