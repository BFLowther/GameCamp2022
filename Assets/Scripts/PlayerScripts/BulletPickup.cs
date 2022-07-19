using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickup : MonoBehaviour
{
    public int bullets = 1;
    public int bulletCase = 10; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            bullets += bulletCase;
            other.transform.gameObject.SetActive(false);
            other.gameObject.tag = "Untagged";
            Destroy(other.gameObject);
        }
    }
}
