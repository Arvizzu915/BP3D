using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed, jumpForce, rotationSpeed;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rb;
    public bool katana;
    public bool bazooka;
    private bool grounded = true;
    public int selectedWeapon =0;
    [SerializeField] private GameObject kHb;

    Vector3 moveDirection;

    private void Update()
    {
        if (!katana && !bazooka)
        {
            selectedWeapon = 0;
        }

        if (moveDirection !=  Vector3.zero)
        {
            animator.SetBool("Moving", true);

            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
        

        if (grounded) 
        {
            animator.SetBool("Jumping", false);
        }
        else
        {
            animator.SetBool("Jumping", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            selectedWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedWeapon = 2;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveDirection.x * playerSpeed, rb.velocity.y, moveDirection.z * playerSpeed);
    }

    public void ResetLevel()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void Move(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.performed)
        {
            moveDirection = callbackContext.ReadValue<Vector3>();
        }
    }
    
    public void Jump(InputAction.CallbackContext callbackContext) 
    {
        if (grounded && callbackContext.performed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("Bumper"))
        {
            grounded = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("Bumper"))
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Void"))
        {
            ResetLevel();
        }
    }
}
