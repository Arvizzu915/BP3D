using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaScript : MonoBehaviour
{
    [SerializeField] Player player;
    private void Katana(GameObject block) { 
    {
            
        if (block.tag=="Block"&&player.katana)
        {
            block.SetActive(false);
            player.katana = false;
        }
    } }
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F)&& player.selectedWeapon==1) {

            Katana(other.gameObject);
        }
    }
}
