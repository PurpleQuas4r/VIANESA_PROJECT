using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    
    public float speed = 47f;

    public float gravity = -16.81f;

//CAMBIAR VALORES EN UNITY, NO SE CAMBIARAN POR EL SCRIPT
    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;

    bool isGrounded;

    Vector3 velocity;  

    public float jumpHeight = 10;  

    void Update()
    {
        //reiniciar escena
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        //checkear si la vianesa esta en el suelo
        isGrounded = Physics.CheckSphere(groundCheck.position,sphereRadius,groundMask);
        
        if (isGrounded && velocity.y <= 0 ) 
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move= transform.right * x + transform.forward * z;


        if (characterController.isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        characterController.Move(move * speed *Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);

    }
}
