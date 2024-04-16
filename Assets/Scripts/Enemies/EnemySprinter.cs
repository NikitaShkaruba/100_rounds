using Components;
using UnityEngine;

namespace Enemies {
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemySprinter : Enemy {
        [SerializeField] private Direction runDirection;
        private float speed = 4f;

        // Update is called once per frame
        public void FixedUpdate() {
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

        public void OnTriggerEnter2D(Collider2D collider) {
            if (!collider.name.Equals("Arena")) {
                return;
            }

            speed *= 2;
        }
    }
}