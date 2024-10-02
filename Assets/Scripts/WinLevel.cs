using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    [SerializeField] public int ballsToWin;
    [SerializeField] GameObject winpanel;
    [SerializeField] AudioClip winAudio;
    [SerializeField] AudioSource audioSource;
    bool notWon=true;
    private void Update()
    {
        if (ballsToWin <= 0&&notWon) 
        {
            SoundFxManager.instance.PlaySoundFXClip(winAudio, transform, 1f);
            winpanel.SetActive(true);
            Debug.Log("win");
            notWon = false;
            audioSource.Stop();
        }
    }
}
