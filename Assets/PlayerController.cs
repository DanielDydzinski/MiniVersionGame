using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private float moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        // Get horizontal input
        moveInput = Input.GetAxisRaw("Horizontal");

        // Calculate movement
        Vector2 movement = new Vector2(moveInput * moveSpeed * Time.deltaTime, 0f);

        // Apply movement
        transform.Translate(movement);
    }
}
