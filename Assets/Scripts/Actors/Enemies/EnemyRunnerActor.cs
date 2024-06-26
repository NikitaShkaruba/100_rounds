using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(OneDirectionMoveBehaviour))]
    public class EnemyRunnerActor : EnemyActor {
        private OneDirectionMoveBehaviour oneDirectionMoveBehaviour;

        public void Awake() {
            oneDirectionMoveBehaviour = gameObject.GetComponent<OneDirectionMoveBehaviour>();
        }

        public void FixedUpdate() {
            oneDirectionMoveBehaviour.Move();
        }
    }
}