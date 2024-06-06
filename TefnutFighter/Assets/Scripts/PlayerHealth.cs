using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    
    private float currentHealth;

    public Healthbar healthbar;

    void Awake()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthbar.SetMaxHealth(maxHealth);

        if (currentHealth <= 0)
        {
            //Die();//
        }
    }

    private void Die()
    {
        Debug.Log(name + " is dead.");
        gameObject.SetActive(false);
    }
}
