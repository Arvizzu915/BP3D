using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Transform portalExit;
    [SerializeField] AudioClip portalSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.transform.position = portalExit.transform.position;
            SoundFxManager.instance.PlaySoundFXClip(portalSound, transform, 1f);
        }
    }
}
