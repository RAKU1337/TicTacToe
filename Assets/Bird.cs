using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public Rigidbody2D rb;
    public float Force;
    public Sprite DeadBird;
    public SpriteRenderer spriteRenderer;
    public Animator anim;
    public int punkty;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, Force);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Punkt")
        {
            Debug.Log("Kolizja: " + collision.name);
            anim.enabled = false;
            spriteRenderer.sprite = DeadBird;
            rb.velocity = new Vector2(0, Force);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Punkt")
        {
            punkty++;
        }
    }


}

