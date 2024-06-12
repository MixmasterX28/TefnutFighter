using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    
    [SerializeField]private float currentHealth;

    public Healthbar healthbar;

    void Awake()
    {
        currentHealth = maxHealth;
        healthbar.SetHealth(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);

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
