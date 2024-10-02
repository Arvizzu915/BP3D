using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class HitBall : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Bazooka bazookaScript;
    [SerializeField] List<Ball> balls = new List<Ball>();
    [SerializeField] public Ball ballScript;
    [SerializeField] AudioClip ballAudioClip;
    [SerializeField] float cooldown;

    public bool playerInRange = false;

    public static HitBall instance;

    private void Awake()
    {
        instance = this;
    }

    public void Hit(InputAction.CallbackContext callbackContext)
    {
        if (playerInRange && callbackContext.performed && Time.time - cooldown > 1.5f)
        {
            cooldown = Time.time;
            bazookaScript.BazookaFunction(gameObject);
            SoundFxManager.instance.PlaySoundFXClip(ballAudioClip,transform,1f);
            foreach (Ball ball in balls) 
            {
                ball.ballIndex = 0;
            }
            ballScript.ballIndex = 1;
            ballScript.moving = true;
        }
    }

}
