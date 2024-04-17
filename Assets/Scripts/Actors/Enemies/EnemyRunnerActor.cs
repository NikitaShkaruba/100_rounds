using HumbleObjects.Movement;

namespace Actors.Enemies {
    public class EnemyRunnerActor : EnemyActor {
        private OneDirectionMoveBehaviour oneDirectionMoveBehaviour;

        public void Awake() {
            oneDirectionMoveBehaviour = gameObject.GetComponent<OneDirectionMoveBehaviour>();
        }

        public void FixedUpdate() {
            oneDirectionMoveBehaviour.Accelerate(3f);
        }
    }
}