using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private PlayerInput input;
    private InputAction moveAction;

    private Rigidbody2D rb;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();

        moveAction = input.actions["Move"];
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.Log(moveAction.ReadValue<Vector2>());
        Vector2 movement = speed * Time.fixedDeltaTime * moveAction.ReadValue<Vector2>();
        //Debug.Log(movement);
        rb.AddForce(movement, ForceMode2D.Impulse);
    }
}
