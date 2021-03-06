using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLOOK : MonoBehaviour
{

    public float mouseSensitivity = 80f;
    public Transform playerBody;
    float xRotation = 0;

    void Update()
    {
        if (PauseMenu.GameIsPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            
        }

        if (!PauseMenu.GameIsPaused)
        {
            //CURSOR
            Cursor.lockState = CursorLockMode.Locked;
            

            //CAMARA
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;

            xRotation -= mouseY;

            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        
            playerBody.Rotate(Vector3.up * mouseX);

            //-----------------------------------------------------

        }
        
    }
}
