using Shared;
using UnityEngine;

namespace HumbleObjects.Movement {
    public class MoveInArenaBehaviour : MoveBehaviour {
        protected override Vector2 ComputeVelocity(Direction direction) {
            var velocity = base.ComputeVelocity(direction);

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