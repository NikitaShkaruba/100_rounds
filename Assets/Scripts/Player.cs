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
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 4f;
        rigidbody.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}
