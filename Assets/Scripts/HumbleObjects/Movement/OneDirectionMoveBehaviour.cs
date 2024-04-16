using Shared;
using UnityEngine;

namespace HumbleObjects.Movement {
    public class OneDirectionMoveBehaviour : MoveBehaviour {
        [SerializeField] private Direction runDirection;

        public void Move(float speed) {
            base.Move(runDirection, speed);
        }
    }
}