using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour
{
    [SerializeField] int powerUpType = 1;
    [SerializeField] AudioClip powerupSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player")) {
            Player hasPowerup=other.GetComponent<Player>();
        if(powerUpType==1&&!hasPowerup.katana)
        {
            hasPowerup.katana = true;
            gameObject.SetActive(false);
                SoundFxManager.instance.PlaySoundFXClip(powerupSound, transform, 1f);
        } 
        else
            { hasPowerup.bazooka = true;
              gameObject.SetActive (false);
                SoundFxManager.instance.PlaySoundFXClip(powerupSound, transform, 1f);
            }
        }
        
        
    }
    private void Update()
    {
        if(powerUpType==1) {transform.Rotate(0, 10 * Time.deltaTime, 0); }
        else
        { 
            transform.Rotate(22 * Time.deltaTime, 0, 0); 
        }
    }
}
