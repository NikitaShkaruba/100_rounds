using Shared;
using UnityEngine;

namespace HumbleObjects.Movement {
    public class ArenaMoveBehaviour : MoveBehaviour {
        protected override Vector2 ComputeVelocity(Direction direction, float speed) {
            var velocity = base.ComputeVelocity(direction, speed);

            const float borderY = 1.95f;
            const float borderX = 3.7f;

            if (velocity.y > 0 && rigidbody.position.y > borderY) {
                velocity.y = 0;
            }
            if (velocity.y < 0 && rigidbody.position.y < -borderY) {
                velocity.y = 0;
            }
            if (velocity.x > 0 && rigidbody.position.x > borderX) {
                velocity.x = 0;
            }
            if (velocity.x < 0 && rigidbody.position.x < -borderX) {
                velocity.x = 0;
            }

            return velocity;
        }
    }
}