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

    public float characterDirection;

    public bool isFacingRight;

    public GameObject obstacleRayObject;

    private object player;

    public float obstacleRayDistance;

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y); //Horizontal movement.
        isFacingRight = (Input.GetAxis("Horizontal") > 0.0f); //Facing left or right based on movement.

        if (isFacingRight == true)
        {
            characterDirection = -1f;
        } else
        {
            characterDirection = 1;
        }

        if (health == 0) //You die if you reach 0 health.
        {
            Debug.Log("Die");
            Destroy(gameObject);
        }

        RaycastHit2D hitObstacle = Physics2D.Raycast(obstacleRayObject.transform.position, Vector2.right * new Vector2(characterDirection,0f), obstacleRayDistance);

        if (hitObstacle.collider != null)
        {
            Debug.Log("Hitting!");
            Debug.DrawRay(obstacleRayObject.transform.position, Vector2.right * hitObstacle.distance * new Vector2(characterDirection, 0f), Color.red);
        }
        else
        {
            Debug.Log("Not Hitting!");
            Debug.DrawRay(obstacleRayObject.transform.position, Vector2.right * hitObstacle.distance * new Vector2(characterDirection, 0f), Color.green);
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