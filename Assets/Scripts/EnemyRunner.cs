using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRunner : MonoBehaviour
{
    
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    };

    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private Direction runDirection;
    // Update is called once per frame
    void FixedUpdate()
    {
        const float speed = 4f;
        float verticalVelocity = 0;
        float horizontalVelocity = 0;
        
        switch (runDirection) {
            case Direction.Up:
                verticalVelocity = speed;
                break;
            case Direction.Right:
                horizontalVelocity = speed;
                break;
            case Direction.Down:
                verticalVelocity = -speed;
                break;
            case Direction.Left:
                horizontalVelocity = -speed;
                break;
        }

        rigidbody.velocity = new Vector2(horizontalVelocity, verticalVelocity);
    }
    
    // Disable this script when the GameObject moves out of the camera's view
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
