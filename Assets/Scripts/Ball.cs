using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int ballIndex = 0;
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    [SerializeField] BoxCollider Boxcollider;
    [SerializeField] Player playerScript;
    [SerializeField] AudioClip ballAudio;
    public Vector3 direction;
    public bool moving = false;

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (moving)
        {
            rb.velocity = new Vector3 (direction.x * speed, rb.velocity.y, direction.z *speed);
        }
    }

    public void RoundPosition()
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x), 1.4f, Mathf.Round(transform.position.z));
        if ((transform.position.x % 2 != 0) || (transform.position.z % 2 != 0)) 
        {
            transform.position = transform.position + -direction;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && moving)
        {
            playerScript.ResetLevel();
        }

        if (collision.gameObject.CompareTag("Bumper"))
        {
            rb.velocity = Vector3.zero;
            moving = false;
            RoundPosition();
            transform.position = new Vector3(transform.position.x + (-direction.x / 7), transform.position.y, transform.position.z + (-direction.z / 7));
        }

        if (moving && collision.gameObject.CompareTag("Ball"))
        {
            SoundFxManager.instance.PlaySoundFXClip(ballAudio, transform, 1f);
            Ball ballScript = collision.gameObject.GetComponent<Ball>();
            if (ballIndex > ballScript.ballIndex)
            {
                ballScript.direction = direction;
                ballScript.moving = true;
                moving = false;
                rb.velocity = Vector3.zero;
                RoundPosition();
                ballScript.ballIndex = ballIndex++;
            }
        }
    }
}
