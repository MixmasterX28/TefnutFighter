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
    [SerializeField] private KeyCode punchKey = KeyCode.E; // Ajusta las teclas para cada jugador
    [SerializeField] private KeyCode heavyPunchKey = KeyCode.R; // Ajusta las teclas para cada jugador
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
        if (Input.GetKeyDown(punchKey) && TimeNextPunch <= 0)
        {
            Golpe();
            TimeNextPunch = TimePunch;
        }
        if (Input.GetKeyDown(heavyPunchKey) && TimeNextPunch <= 0)
        {
            GolpeHeavy();
            TimeNextPunch = TimePunch;
        }
    }

    private void Golpe()
    {
        animator.SetTrigger("Punch");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Player"))
            {
                colisionador.transform.GetComponent<PlayerHealth>().TakeDamage(punchDamage); // Asegúrate de que tus jugadores tengan el componente PlayerHealth
            }
        }
    }

    private void GolpeHeavy()
    {
        animator.SetTrigger("HeavyPunch");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Player"))
            {
                colisionador.transform.GetComponent<PlayerHealth>().TakeDamage(punchDamage); // Asegúrate de que tus jugadores tengan el componente PlayerHealth
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }
}
