using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCac : MonoBehaviour
{
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float punchDamage;
    [SerializeField] private float TimePunch;
    [SerializeField] private float TimeNextPunch;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (TimeNextPunch > 0)
        {
            TimeNextPunch -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.E) && TimeNextPunch <= 0)
        {
            Golpe();
            TimeNextPunch = TimePunch;
        }
    }
    private void Golpe()
    {
        animator.SetTrigger("Punch");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TakeDamage(punchDamage);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }


}
