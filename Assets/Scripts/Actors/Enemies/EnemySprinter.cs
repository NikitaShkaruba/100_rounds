using HumbleObjects;
using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    public class EnemySprinter : Enemy {
        private ArenaSpeedChangeable arenaSpeedChangeable;
        private OneDirectionMoveBehaviour oneDirectionMoveBehaviour;

        public void Awake() {
            arenaSpeedChangeable = new ArenaSpeedChangeable();

            oneDirectionMoveBehaviour = gameObject.GetComponent<OneDirectionMoveBehaviour>();
        }

        public void FixedUpdate() {
            oneDirectionMoveBehaviour.Move(arenaSpeedChangeable.speed);
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            arenaSpeedChangeable.ProcessCollision(collider);
        }
    }
}