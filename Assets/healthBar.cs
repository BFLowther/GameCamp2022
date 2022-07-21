using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBar : MonoBehaviour
{
    public Slider slider;

   public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void LateUpdate() //happens after update to not compete with movement
    {
        transform.position = target.position + offset;

    }
    

}
