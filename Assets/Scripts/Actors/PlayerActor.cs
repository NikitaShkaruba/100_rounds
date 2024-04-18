using HumbleObjects;
using HumbleObjects.Movement;
using UnityEngine;

namespace Actors {
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    [RequireComponent(typeof(DieBehaviour))]
    [RequireComponent(typeof(ArenaMoveBehaviour))]
    public class PlayerActor : MonoBehaviour {
        private ArenaMoveBehaviour arenaMoveBehaviour;
        private DieBehaviour dieBehaviour;
        private PlayerControllable playerControllable;

        public void Awake() {
            playerControllable = new PlayerControllable();

            dieBehaviour = gameObject.GetComponent<DieBehaviour>();
            arenaMoveBehaviour = gameObject.GetComponent<ArenaMoveBehaviour>();
        }

        public void Update() {
            playerControllable.UpdatePlayerInput();
            Debug.Log("Player position: " + arenaMoveBehaviour.rigidbody.position);
        }

        public void FixedUpdate() {
            if (dieBehaviour.isDead) {
                arenaMoveBehaviour.StopMovement();
                return;
            }

            arenaMoveBehaviour.Move(playerControllable.GetMoveDirection(), 4f);
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            dieBehaviour.Process(collider);
        }
    }
}