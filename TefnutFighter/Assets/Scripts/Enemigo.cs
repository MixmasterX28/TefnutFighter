using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float health;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamage (float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Muerte();
        }

    }
    private void Muerte ()
    {
        animator.SetTrigger ("Muerte");
    }
}
