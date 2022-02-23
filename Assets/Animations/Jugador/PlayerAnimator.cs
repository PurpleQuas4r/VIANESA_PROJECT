using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("isRunning", true);
        }

        if (!Input.GetKey("w"))
        {
            anim.SetBool("isRunning", false);
        }

        //retrocediendo
        if (Input.GetKey("s"))
        {
            anim.SetBool("retrocediendo", true);
        }

        if (!Input.GetKey("s"))
        {
            anim.SetBool("retrocediendo", false);
        }

        //right
        if (Input.GetKey("d"))
        {
            anim.SetBool("walkR", true);
        }

        if (!Input.GetKey("d"))
        {
            anim.SetBool("walkR", false);
        }

        //left
        if (Input.GetKey("a"))
        {
            anim.SetBool("walkL", true);
        }

        if (!Input.GetKey("a"))
        {
            anim.SetBool("walkL", false);
        }

        //sword
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("fight", true);
        }

        if (!Input.GetMouseButtonDown(0))
        {
            anim.SetBool("fight", false);
        }

        //saltar
        if (Input.GetKey("space"))
        {
            anim.SetBool("jump", true);
        }

        if (!Input.GetKey("space"))
        {
            anim.SetBool("jump", false);
        }

    }
}
