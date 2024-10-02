using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaScript : MonoBehaviour
{
    [SerializeField] Player player;
    private bool selectingBox = false;
    private GameObject box;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && selectingBox && player.katana && player.selectedWeapon == 1)
        {
            Katana(box);
        }
    }

    private void Katana(GameObject block)
    {
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
