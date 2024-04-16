using UnityEngine;

namespace HumbleObjects {
    public class ArenaSpeedChangeable {
        public float speed = 3f;

        public void ProcessCollision(Collider2D collider) {
            if (!collider.name.Equals("Arena")) {
                return;
            }

            speed *= 2;
        }
    }
}