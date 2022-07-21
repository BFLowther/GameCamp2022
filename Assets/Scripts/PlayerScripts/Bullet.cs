using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public float direction = 1;
    public float speed = 20; 
    public float lifeTime = 3.0f;
    public Rigidbody2D bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
        bullet.velocity = new Vector2(direction*speed, 0);
        Destroy(gameObject, lifeTime);    
    }
   
     void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        // TODO (Jonah) : deal damage
        if(col.gameObject.tag == "Enemy"){
            col.gameObject.GetComponent<Health>().Damage(damage);
            damage = 0;
            Destroy(gameObject);
        }

        if(col.gameObject.tag == "Ground"){ 
            Destroy(gameObject);
        }
    }
}
