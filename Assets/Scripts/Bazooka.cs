using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] float ballForce = 40;
   
    // Start is called before the first frame update
   public void BazookaFunction(GameObject ball) {
        if (player.selectedWeapon == 2 && player.bazooka) 
        {
            Debug.Log("k boom");
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * ballForce, ForceMode.Impulse); 
            player.bazooka = false;
        }
    }
}
