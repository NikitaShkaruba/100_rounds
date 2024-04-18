using UnityEngine;

namespace HumbleObjects.Movement {
    public class PreArenaStoppableMoveBehaviour : OneDirectionMoveBehaviour {
        [HideInInspector] public bool isStopped;

        public new void Move() {
            if (isStopped) {
                StopMovement();
                return;
            }

            base.Move(runDirection);
        }

        public void CheckIfNeedsToStop(Collider2D collider) {
            if (!collider.name.Equals("PreArena")) {
                return;
            }

            isStopped = true;
        }
    }
}