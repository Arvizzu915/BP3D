using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaScript : MonoBehaviour
{
    [SerializeField] Player player;
    private bool selectingBox = false;
    private GameObject box;
    [SerializeField] AudioClip slash;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && selectingBox && player.katana && player.selectedWeapon == 1)
        {
            
            Katana(box);
        }
    }

    private void Katana(GameObject block)
    {
        SoundFxManager.instance.PlaySoundFXClip(slash, transform, 1f);
            block.SetActive(false);
            player.katana = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Bumper"))
        {
            
            box = other.gameObject;
            selectingBox = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bumper"))
        {
            box = null;
            selectingBox = false;
        }
    }
}
