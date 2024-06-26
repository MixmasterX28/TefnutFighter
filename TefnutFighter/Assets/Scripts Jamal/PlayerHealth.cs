using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    
    [SerializeField]private float currentHealth;

    public Healthbar healthbar;

   // void Awake()
   // {
   // }

    public void InitHealthBar()
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
            Die();
        }
    }

    private void Die()
    {
        Debug.Log(name + " is dead.");
        gameObject.SetActive(false);
        SceneManager.LoadSceneAsync(4);
    }
}
