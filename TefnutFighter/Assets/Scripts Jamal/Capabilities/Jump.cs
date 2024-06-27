using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public InputController input = null;
    [SerializeField, Range(0f, 50f)] private float jumpHeight = 4f;
    [SerializeField, Range(0, 5)] private int maxAirJump = 1;
    [SerializeField, Range(0f, 5f)] private float downwardMovementMultiplier = 3f;
    [SerializeField, Range(0f, 5f)] private float upwardMovementMultiplier = 1.7f;

    private Rigidbody2D body;
    private Ground ground;
    private Vector2 velocity;

    private int jumpPhase;
    private float defaultGravityScale;

    private bool desiredJump;
    private bool onGround;

    void Awake()
    {



        body = GetComponent<Rigidbody2D>();
        ground = GetComponent<Ground>();

        defaultGravityScale = 1f;
    }
    private void Start()
    {


    }
    void Update()
    {

       
       if(input!=null)desiredJump |= input.RetrieveJumpInput();
        
    }

    private void FixedUpdate()
    {
        onGround = ground.GetOnGround();
        velocity = body.velocity;

        if (onGround)
        {
            jumpPhase = 0;
        }

        if (desiredJump)
        {
            desiredJump = false;
            JumpAction();
        }

        if (body.velocity.y > 0)
        {
            body.gravityScale = upwardMovementMultiplier;
        }
        else if (body.velocity.y < 0)
        {
            body.gravityScale = downwardMovementMultiplier;
        }
        else
        {
            body.gravityScale = defaultGravityScale;
        }

        body.velocity = velocity;
    }

    private void JumpAction()
    {
        if (onGround || jumpPhase < maxAirJump)
        {
            jumpPhase += 1;
            float jumpSpeed = Mathf.Sqrt(-2 * Physics2D.gravity.y * jumpHeight);
            if (velocity.y > 0f)
            {
                jumpSpeed = Mathf.Max(jumpSpeed - velocity.y, 0f);
            }
            velocity.y = jumpSpeed;
        }
    }
}
