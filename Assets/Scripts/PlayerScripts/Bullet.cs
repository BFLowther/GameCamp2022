using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public float direction = 1;
    public float speed = 20; 
    public float lifeTime = 3.0f;
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(direction*speed, 0);
        Destroy(gameObject, lifeTime);    
    }
   
     void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        // TODO (Jonah) : deal damage
    }
}
