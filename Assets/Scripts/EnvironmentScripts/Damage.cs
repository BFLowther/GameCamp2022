using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    [HideInInspector]
    public playerBehavior pb;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pb = other.gameObject.GetComponent<playerBehavior>();
            healthBar hb = pb.HealthBar;
            hb.SetHealth(hb.currentHealth - 1);
            if (pb.currentHealth == 0)
            {
                SceneManager.LoadScene("Ross2");

            }
        }
    }

}
