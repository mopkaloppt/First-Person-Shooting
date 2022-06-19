using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
    }
    
    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        // Must stop the time so the player can have a cursor back smoothly
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        // Don't lock the cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;      
    }
}
