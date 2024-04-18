using HumbleObjects;
using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(ArenaSprintBehaviour))]
    [RequireComponent(typeof(OneDirectionMoveBehaviour))]
    public class EnemySprinterActor : EnemyActor {
        private ArenaSprintBehaviour arenaSprintBehaviour;
        private OneDirectionMoveBehaviour oneDirectionMoveBehaviour;

        public void Awake() {
            arenaSprintBehaviour = gameObject.GetComponent<ArenaSprintBehaviour>();
            oneDirectionMoveBehaviour = gameObject.GetComponent<OneDirectionMoveBehaviour>();
        }

        public void Start() {
            arenaSprintBehaviour.Initialize(oneDirectionMoveBehaviour.runDirection);
        }

        public void FixedUpdate() {
            oneDirectionMoveBehaviour.Move(arenaSprintBehaviour.speed);
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            arenaSprintBehaviour.ProcessCollision(collider);
        }
    }
}