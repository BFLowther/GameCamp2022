using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthgain = 1;
    public playerBehavior pb;

    // Start is called before the first frame update
    void Start()
    {
        pb = gameObject.GetComponent<playerBehavior>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("healthgain"))
        {
            pb.HealthBar.SetHealth(healthgain + pb.HealthBar.currentHealth);
            other.transform.gameObject.SetActive(false);
            //other.gameObject.tag = "Untagged";
            Destroy(other.gameObject);
        }
    }
}
