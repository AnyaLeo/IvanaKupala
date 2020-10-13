using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // The motor that drives our player
    public Rigidbody controller;

    public float speed = 6f;

    private Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        // Input

        // X axis (horizontal) and Z axis (vertical) input
        // Y axis for moving up and down
        movement.x = -Input.GetAxisRaw("Horizontal");
        movement.z = -Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        // Movement
        controller.MovePosition(
                 controller.position + movement * speed * Time.fixedDeltaTime);
    }
}
