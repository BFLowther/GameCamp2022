using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Transform pos1, pos2;



    public float speedOfEnemy = 1;
    Vector3 nextPos;
    private Vector3 lastPosition;


    //public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody m_Rigidbody;
        lastPosition = transform.position;
        nextPos = pos1.position;

    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speedOfEnemy * Time.deltaTime); //Movement!

        //spriteRenderer.flipX = ((transform.position - lastPosition).x > 0.0f);
        lastPosition = transform.position;

        
        //int layerMask = DefaultRaycastLayers
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, new Vector2(2,2), 0.0f, Vector2.zero, Mathf.Infinity, 0, -Mathf.Infinity, Mathf.Infinity);

        foreach(RaycastHit2D ray in hits)
        {
            Debug.Log("Hit : " + ray.collider.name);
        }

    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetAxis("Horizontal") != 0.0f)
            {
                collision.transform.parent = null;
            }

            else
            {
                collision.transform.parent = transform;
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = null;
        }
    }
    
    }

