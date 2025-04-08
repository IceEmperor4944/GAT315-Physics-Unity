using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float jumpHeight = 2;

    Rigidbody2D rb;
    Vector2 force;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direction = Vector2.zero;
        direction.x = Input.GetAxis("Horizontal");

        force = direction * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * Mathf.Sqrt(-2 * Physics.gravity.y * jumpHeight), ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(force.x, rb.linearVelocity.y);
    }
}