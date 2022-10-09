using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player ins;
    Rigidbody2D body;

    public float speed;
    public float jumpForce;

    public ParticleSystem jumpFX;
    public ParticleSystem deadFX;
    void Start()
    {
        ins = this;
        body = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;
        if (InputManager.JumpTriggered)
        {
            //body.velocity = new Vector2(body.velocity.x, jumpForce);
            y = jumpForce;
            jumpFX.Play();
        }
        else
        {
            y = body.velocity.y;
        }
        body.velocity = new Vector2(InputManager.xSpeed * speed, y);

        Vector2 pos = transform.position;
        if (Mathf.Abs(pos.x) > 8.5f || Mathf.Abs(pos.y) > 4.6f)
        {
            GameManager.ins.Lose();

        }

    }
    
}
