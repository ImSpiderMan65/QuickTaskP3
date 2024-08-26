using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     Rigidbody2D rb2d; 
     public float upForce = 5f;
    public float speed = 10;
    SpriteRenderer playersprite;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playersprite = GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");

    transform.Translate(Vector2.right * horizontal * speed * Time.deltaTime);

        if (horizontal >= 0)
        {
            playersprite.flipX = false;
            
        }
        else
        {
             playersprite.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);

        }

    }
}
