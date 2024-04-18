using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(PreArenaStoppableMoveBehaviour))]
    public class EnemyCatapultActor : EnemyActor {
        private PreArenaStoppableMoveBehaviour preArenaStoppableMoveBehaviour;

        public void Awake() {
            preArenaStoppableMoveBehaviour = GetComponent<PreArenaStoppableMoveBehaviour>();
        }

        public void FixedUpdate() {
            preArenaStoppableMoveBehaviour.Move();
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            preArenaStoppableMoveBehaviour.CheckIfNeedsToStop(collider);
        }
    }
}