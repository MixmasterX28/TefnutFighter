using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public InputController input = null;
    [SerializeField] private float velocidadDeMovimiento;
    private Animator animator;
    private float movimientoHorizontal = 0f;
    private float movimientoVertical = 0f;

    public JMove jMovescript;
    private bool desiredJump = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("input?" + input);
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocityX = jMovescript.velocity.x;

      
       // movimientoVertical = Input.GetAxisRaw("Vertical") * velocidadDeMovimiento;

        animator.SetFloat("Horizontal", Mathf.Abs(velocityX));

        //animator.speed = Mathf.Abs(velocityX);
        if (animator.GetCurrentAnimatorStateInfo(0).Equals("walk"))
        {
            Debug.Log("walking");
           
        }


        if (input.RetrieveJumpInput())
        {
            Debug.Log("jump!!");
            animator.speed = 1;

            animator.SetTrigger("Jump");
           // animator.SetFloat("jump", Mathf.Abs(movimientoVertical));
        }
        
            
    }
}
