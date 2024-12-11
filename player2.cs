using UnityEngine;

public class Player2 : MonoBehaviour
{
    private PlayerMovement movement; // Reference to the PlayerMovement script

    private void Awake()
    {
        // Get the PlayerMovement component attached to Player2 GameObject
        movement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        // Handle movement and jumping for Player 2
        Move();
        Jump();
    }

    private void Move()
    {
        // Use Horizontal2 axis for Player 2's movement
        float moveInput = Input.GetAxis("Horizontal2");
        movement.Move(moveInput); // Call the Move() method in PlayerMovement
    }

    private void Jump()
    {
        // Use Jump2 axis for Player 2's jumping
        if (Input.GetButtonDown("Jump2"))
        {
            movement.Jump(); // Call the Jump() method in PlayerMovement
        }
    }
}
