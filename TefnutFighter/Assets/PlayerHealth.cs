using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Implementa la lógica de muerte del jugador (ej., desactivar el jugador, reproducir animación, etc.)
        Debug.Log(name + " ha muerto.");
        gameObject.SetActive(false);
    }
}
