using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Animation2 : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movimientoHorizontal = -1 * velocidadDeMovimiento;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movimientoHorizontal = -1 * velocidadDeMovimiento;
        }
        else
        {
            movimientoHorizontal = 0;
        }

        animator.SetFloat("Horizontal2", Mathf.Abs(movimientoHorizontal));

    }
}
