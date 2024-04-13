using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;

    [SerializeField] private Rigidbody2D rigidbody;

    void Update() {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");

        Debug.Log("Player position: " + rigidbody.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        const float speed = 4f;

        float verticalVelocity = verticalInput * speed;
        float horizontalVelocity = horizontalInput * speed;

        // Check for borders
        const float borderY = 1.95f;
        if (verticalVelocity > 0 && rigidbody.position.y > borderY) {
            verticalVelocity = 0;
        }
        if (verticalVelocity < 0 && rigidbody.position.y < -borderY) {
            verticalVelocity = 0;
        }
        const float borderX = 3.7f;
        if (horizontalVelocity > 0 && rigidbody.position.x > borderX) {
            horizontalVelocity = 0;
        }
        if (horizontalVelocity < 0 && rigidbody.position.x < -borderX) {
            horizontalVelocity = 0;
        }

        rigidbody.velocity = new Vector2(horizontalVelocity, verticalVelocity);
    }
}
