using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int potion = 1;
    public GameObject Player;
    public playerBehavior pb;

    // Start is called before the first frame update
    void Start()
    {
        pb = Player.GetComponent<playerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("potion"))
        {
            pb.currentHealth += potion;
            other.transform.gameObject.SetActive(false);
            other.gameObject.tag = "Untagged";
            Destroy(other.gameObject);
        }
    }
}
