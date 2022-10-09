using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.ins.Lose();
        }
        if (collision.CompareTag("Scorer"))
        {
            GameManager.ins.AddScore();
        }
    }
}
