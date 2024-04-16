using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    private float horizontalInput;

    private new Rigidbody2D rigidbody;
    private float verticalInput;

    public void Start() {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Update() {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");

        Debug.Log("Player position: " + rigidbody.position);
    }

    // Update is called once per frame
    public void FixedUpdate() {
        const float speed = 4f;

        var verticalVelocity = verticalInput * speed;
        var horizontalVelocity = horizontalInput * speed;

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

    public void OnTriggerEnter2D(Collider2D collider) {
        CheckDeath(collider);
    }

    private void CheckDeath(Collider2D collider) {
        if (!collider.name.Contains("Enemy")) {
            return;
        }

        Debug.Log("U DED");
        Destroy(gameObject);
    }
}