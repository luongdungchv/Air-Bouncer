using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public static float xSpeed;
    public static bool JumpTriggered;
    public bool useTouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!useTouch)
        {
            xSpeed = Input.GetAxis("Horizontal");
            //JumpTriggered = Input.GetKeyDown(KeyCode.Space);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(Jump());
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                JumpTriggered = false;
            }
        }
        
    }
    IEnumerator Jump()
    {
        JumpTriggered = true;
        yield return null;
        JumpTriggered = false;
    }
}
