using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JMove : MonoBehaviour
{
    [SerializeField] private InputControler input = null;
    [SerializeField, Range(0f, 100f)] private float maxSpeed = 4f;
    [SerializeField, Range(0f, 100f)] private float maxAcceleration = 35f;
    [SerializeField, Range(0f, 100f)] private float maxAirAcceleration = 20f;

    private Vector2 direction;
    private Vector2 desiredVelocity;
    private Vector2 velocity;
    private Rigidbody2D body;
    private Ground ground;

    private float maxSpeedChange;
    private float acceleration;
    private bool onGround;
<<<<<<< Updated upstream
    private bool facingRight = true; // Variable para controlar la dirección del personaje
=======
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Awake()
    {
<<<<<<< Updated upstream
        body = GetComponent<Rigidbody2D>();
=======
       body = GetComponent<Rigidbody2D>();
>>>>>>> Stashed changes
        ground = GetComponent<Ground>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = input.RetrieveMoveInput();
        desiredVelocity = new Vector2(direction.x, 0f) * Mathf.Max(maxSpeed - ground.Getfriction(), 0);

<<<<<<< Updated upstream
        // Girar el personaje según la dirección de movimiento
        if (direction.x > 0 && !facingRight)
        {
            Flip();
        }
        else if (direction.x < 0 && facingRight)
        {
            Flip();
        }
=======

>>>>>>> Stashed changes
    }

    private void FixedUpdate()
    {
        onGround = ground.GetOnGround();
        velocity = body.velocity;

        acceleration = onGround ? maxAcceleration : maxAirAcceleration;
        maxSpeedChange = acceleration * Time.deltaTime;
        velocity.x = Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);

        body.velocity = velocity;
    }
<<<<<<< Updated upstream

    private void Flip()
    {
        // Cambiar la dirección del personaje
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1; // Invertir la escala en el eje X
        transform.localScale = scale;
    }
=======
>>>>>>> Stashed changes
}
