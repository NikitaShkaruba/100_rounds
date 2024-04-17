using Shared;

namespace HumbleObjects.Movement {
    public class OneDirectionMoveBehaviour : MoveBehaviour {
        public Direction runDirection;

        public void Accelerate(float speed) {
            base.Accelerate(runDirection, speed);
        }
    }
}