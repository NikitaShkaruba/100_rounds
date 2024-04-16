using Components;
using UnityEngine;

namespace Enemies {
    public class EnemyRunner : Enemy {
        [SerializeField] private Direction runDirection;

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
    }
}