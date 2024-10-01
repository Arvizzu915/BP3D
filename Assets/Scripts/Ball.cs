using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    public Vector3 direction;
    public bool moving = false;

    private void FixedUpdate()
    {
        if (moving)
        {
            rb.isKinematic = false;
            rb.velocity = direction * speed;
        }
    }

    public void RoundPosition(float offset)
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x + offset), 1.5f, Mathf.Round(transform.position.z + offset));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bumper"))
        {
            rb.velocity = Vector3.zero;
            transform.position = transform.position + (-direction * .05f);
            rb.isKinematic = true;
            moving = false;
            RoundPosition(0.3f);
        }

        if (collision.gameObject.CompareTag("Ball"))
        {
            rb.velocity = Vector3.zero;
            transform.position = transform.position + (-direction * .05f);
            rb.isKinematic = true;
            moving = false;
            Ball ballScript = collision.gameObject.GetComponent<Ball>();
            ballScript.moving = true;
            ballScript.direction = direction;
            RoundPosition(0);
        }
    }
}
