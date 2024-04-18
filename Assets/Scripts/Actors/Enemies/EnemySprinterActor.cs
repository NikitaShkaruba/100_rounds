using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(ArenaSprintableMoveBehaviour))]
    public class EnemySprinterActor : EnemyActor {
        private ArenaSprintableMoveBehaviour arenaSprintableMoveBehaviour;

        public void Awake() {
            arenaSprintableMoveBehaviour = gameObject.GetComponent<ArenaSprintableMoveBehaviour>();
        }

        public void Start() {
            arenaSprintableMoveBehaviour.Initialize(arenaSprintableMoveBehaviour.runDirection);
        }

        public void FixedUpdate() {
            arenaSprintableMoveBehaviour.Move();
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            arenaSprintableMoveBehaviour.CheckIfNeedsToSprint(collider);
        }
    }
}