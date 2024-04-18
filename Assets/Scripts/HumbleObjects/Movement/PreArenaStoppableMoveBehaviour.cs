using UnityEngine;

namespace HumbleObjects.Movement {
    public class PreArenaStoppableMoveBehaviour : OneDirectionMoveBehaviour {
        private bool isStopped;

        public new void Move() {
            if (isStopped) {
                StopMovement();
                return;
            }

            base.Move(runDirection);
        }

        public void CheckIfNeedsToStop(Collider2D collider) {
            if (!collider.name.Equals("Arena")) {
                return;
            }

            isStopped = true;
        }
    }
}