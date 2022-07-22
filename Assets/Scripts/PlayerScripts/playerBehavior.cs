using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    public int currentHealth;
    public Rigidbody2D body;
    public rangedWeapons RangedWeapons;
    // Start is called before the first frame update

    public float speed = 7;

    public float jump = 3;

    public int maxHealth = 10;

    public float characterDirection;

    public bool isFacingRight;

    public float maxY;

    public GameObject obstacleRayObjectLeft;
    public GameObject obstacleRayObjectRight;
    private GameObject obstacleRayObject;

    public cameraShake cameraShake;

    private object player;

    public float obstacleRayDistance = 0;

    public healthBar HealthBar;

    private Animator anim;

    


      void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
        HealthBar.SetHealth(maxHealth);
        anim = gameObject.GetComponent<Animator>();
    }
    private void Awake()
    {
        obstacleRayObject = obstacleRayObjectRight;
    }
    void Update()
    {
        body.velocity = new Vector2(body.velocity.x, Mathf.Clamp(body.velocity.y, -maxY, maxY));
        
        
        //Debug.DrawRay(transform.position, forward, Color.green);
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y); //Horizontal movement.
        if (Input.GetAxis("Horizontal") > 0.0f)
        {
            characterDirection = 1.0f;
            obstacleRayObject = obstacleRayObjectRight;
            anim.SetFloat("walk", body.velocity.x);
        }
        if (Input.GetAxis("Horizontal") < 0.0f)
        {
            characterDirection = -1.0f;
            obstacleRayObject = obstacleRayObjectLeft;
            anim.SetFloat("walk", -body.velocity.x);
        }

        if (currentHealth <= 0) //You die if you reach 0 health.
        {
            Debug.Log("Die");
            Destroy(gameObject);
        }

        Vector3 hitPos = new Vector3(
            (0.1f * characterDirection) + obstacleRayObject.transform.position.x,
            obstacleRayObject.transform.position.y,
            obstacleRayObject.transform.position.z
           );

        RaycastHit2D hitObstacle = Physics2D.Raycast(hitPos, Vector2.right * new Vector2(characterDirection,0f), obstacleRayDistance); //Raycast!

        if (hitObstacle.collider != null)
        {
            if (hitObstacle.collider.gameObject.CompareTag("Ground")) 
            {
                body.velocity = new Vector2(0, body.velocity.y);
                Debug.Log("Hitting!");
                //Debug.Log(hitPos);
                Debug.DrawRay(hitPos, Vector2.right * hitObstacle.distance * new Vector2(characterDirection, 0f), Color.red);
            }
            
        }
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

    }
    void OnTriggerStay2D(Collider2D collider) //Makes character leave the ground.
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            if (Input.GetAxis("Jump") > 0.0f)
            {
                body.velocity = new Vector2(body.velocity.x, body.velocity.y + 1);
            }
        }
        
    }
    void OnTriggerExit2D(Collider2D collider) //Executes the jump.
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            if (Input.GetAxis("Jump") > 0.0f)
            {
                body.velocity = new Vector2(body.velocity.x, body.velocity.y + jump);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collider) //You get hit if you touch an enemy.
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            currentHealth = currentHealth - 1;
            //cameraShake.Shake();
            HealthBar.SetHealth(currentHealth);
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
 
}