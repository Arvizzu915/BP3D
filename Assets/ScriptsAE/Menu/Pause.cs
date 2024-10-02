using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pausePanel,instructions;
    // Start is called before the first frame update
    public void PauseGame()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        { 
            if(pausePanel.activeInHierarchy )
            {
                pausePanel.SetActive(false);
                instructions.SetActive(true);
               
            }
            else
            {
                pausePanel.SetActive(true);
                instructions.SetActive(false);
                
            }
            PauseGame();
           
        }
    }
}
