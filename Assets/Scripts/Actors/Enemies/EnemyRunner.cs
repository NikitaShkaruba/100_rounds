using HumbleObjects.Movement;

namespace Actors.Enemies {
    public class EnemyRunner : Enemy {
        private OneDirectionMoveBehaviour oneDirectionMoveBehaviour;

        public void Awake() {
            oneDirectionMoveBehaviour = gameObject.GetComponent<OneDirectionMoveBehaviour>();
        }

        public void FixedUpdate() {
            oneDirectionMoveBehaviour.Move(3f);
        }
    }
}