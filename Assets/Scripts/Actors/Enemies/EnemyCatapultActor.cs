using HumbleObjects;
using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(PreArenaStoppableMoveBehaviour))]
    [RequireComponent(typeof(ShootBehaviour))]
    public class EnemyCatapultActor : EnemyActor {
        private PreArenaStoppableMoveBehaviour preArenaStoppableMoveBehaviour;
        private ShootBehaviour shootBehaviour;

        public void Awake() {
            preArenaStoppableMoveBehaviour = GetComponent<PreArenaStoppableMoveBehaviour>();
            shootBehaviour = GetComponent<ShootBehaviour>();
        }

        public void FixedUpdate() {
            preArenaStoppableMoveBehaviour.Move();

            if (preArenaStoppableMoveBehaviour.isStopped) {
                shootBehaviour.Shoot();
            }

            if (shootBehaviour.finishedShooting) {
                Destroy(gameObject);
            }
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            preArenaStoppableMoveBehaviour.CheckIfNeedsToStop(collider);
        }
    }
}