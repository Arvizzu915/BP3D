using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] float ballForce=40;
   
    // Start is called before the first frame update
   void BazookaFunction(GameObject ball) {
        if (player.selectedWeapon == 2 && player.bazooka) { Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 1, 0) * ballForce, ForceMode.Impulse); }
       
            }
}
