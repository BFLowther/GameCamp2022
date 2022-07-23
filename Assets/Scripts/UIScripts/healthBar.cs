using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBar : MonoBehaviour
{
    public int currentHealth;
    
    public Slider slider;

   public void SetHealth(int health)
    {
        currentHealth = health;
        slider.value = health;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Ross2");
        }
    }

   public void SetMaxHealth(int health)
   {
       slider.maxValue = health;
       slider.value = health;
   }



   public Transform target;

   public float smoothSpeed = 0.01f;

   public Vector3 offset2;

   void LateUpdate() //happens after update to not compete with movement
   {
        //transform.position = target.position + offset2;

   }
    

}
