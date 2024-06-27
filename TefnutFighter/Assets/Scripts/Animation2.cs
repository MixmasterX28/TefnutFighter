using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation2 : MonoBehaviour
{
    [SerializeField] private float velocidadDeMovimiento;
    private Animator animator;
    private float movimientoHorizontal = 0f;

    public JMove jMovescript;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        float velocityX = jMovescript.velocity.x;



        animator.SetFloat("Horizontal", Mathf.Abs(velocityX));

        //animator.speed = Mathf.Abs(velocityX);
        if (animator.GetCurrentAnimatorStateInfo(0).Equals("walk"))
        {
            Debug.Log("walking");

        }

    }
}
