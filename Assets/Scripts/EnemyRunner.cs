using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyRunner : MonoBehaviour {
    [SerializeField] private Direction runDirection;

    private new Rigidbody2D rigidbody;

    public void Start() {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void FixedUpdate() {
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
    public void OnBecameInvisible() {
        Destroy(gameObject);
    }

    private enum Direction {
        Up,
        Right,
        Down,
        Left
    }
}