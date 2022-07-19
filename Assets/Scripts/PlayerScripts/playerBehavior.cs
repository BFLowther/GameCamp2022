using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{

    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    { }
    public float speed = 7;

    public float jump = 3;

    public float health = 3;

    public bool isFacingRight;

    private object player;

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y); //Horizontal movement.
        isFacingRight = (Input.GetAxis("Horizontal") > 0.0f);

        if (health == 0)
        {
            Debug.Log("Die");
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D collider) //Makes character leave the ground.
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                body.velocity = new Vector2(body.velocity.x, body.velocity.y + 1);
            }
        }
    }
    void OnTriggerExit2D(Collider2D collider) //Executes the jump.
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                body.velocity = new Vector2(body.velocity.x, body.velocity.y + jump);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collider) //Executes the jump.
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            health = health - 1;
        }
    }
    /*
    void OnTriggerEnter2D(Collider2D collider) //Camera shake when hit?
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            
        }
    }
     */

}