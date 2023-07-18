using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;

        StarterAssetsInputs sai = GetComponent<StarterAssetsInputs>();
        sai.cursorLocked = false;
        sai.cursorInputForLook = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
