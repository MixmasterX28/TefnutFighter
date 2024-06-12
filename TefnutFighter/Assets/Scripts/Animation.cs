using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField] private float velocidadDeMovimiento;
    private Animator animator;
    private float movimientoHorizontal = 0f;
    private float movimientoVertical = 0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            movimientoHorizontal = -1 * velocidadDeMovimiento;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            movimientoHorizontal = -1 * velocidadDeMovimiento;
        }
        else
        {
            movimientoHorizontal = 0;
        }
        movimientoVertical = Input.GetAxisRaw("Vertical") * velocidadDeMovimiento;

        animator.SetFloat("Horizontal", Mathf.Abs (movimientoHorizontal));
        animator.SetFloat("ja", Mathf.Abs(movimientoVertical));
    }
}
