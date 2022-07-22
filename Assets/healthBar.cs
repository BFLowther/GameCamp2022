using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBar : MonoBehaviour
{
    public int currentHealth;
    
    public Slider slider;

   public void SetHealth(int Health)
    {
        currentHealth = Health;
        slider.value = Health;
    }

   public void SetMaxHealth(int Health)
   {
       slider.maxValue = Health;
       slider.value = Health;
   }



   public Transform target;

   public float smoothSpeed = 0.01f;

   public Vector3 offset2;

   void LateUpdate() //happens after update to not compete with movement
   {
        //transform.position = target.position + offset2;

   }
    

}
