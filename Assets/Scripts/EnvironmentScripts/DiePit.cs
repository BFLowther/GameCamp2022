using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiePit : MonoBehaviour
{
    [HideInInspector]
    public playerBehavior pb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pb = other.gameObject.GetComponent<playerBehavior>();
            healthBar hb = pb.HealthBar;
            hb.SetHealth(hb.currentHealth - hb.currentHealth);
            SceneManager.LoadScene("Ross2");

        }
    }

}
