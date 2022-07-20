using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    
    public UnityEvent deathEvent;
    public UnityEvent healedEvent;
    public UnityEvent damagedEvent;

    public int maxHealth;
    public int currentHealth;

    void Awake(){
        if(deathEvent == null)
            deathEvent = new UnityEvent();

        if(healedEvent == null)
            healedEvent = new UnityEvent();

        if(damagedEvent == null)
            damagedEvent = new UnityEvent();
    }

    public void Heal(int heal){
        currentHealth += heal;
        if(currentHealth >= maxHealth){
            currentHealth = maxHealth;
        }

        // Event Healed Flash
        healedEvent.Invoke();
    }

    public void Damage(int damage){
        // Deal Damage
         currentHealth -= damage;
        // Event Damage Flash
        damagedEvent.Invoke();

        // Event Player Death
        if(currentHealth <= 0){
            deathEvent.Invoke();    
        }
    }
}