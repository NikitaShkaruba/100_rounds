using Shared;

namespace HumbleObjects.Movement {
    public class OneDirectionMoveBehaviour : MoveBehaviour {
        public Direction runDirection;

        public void Move() {
            base.Move(runDirection);
        }
    }
}