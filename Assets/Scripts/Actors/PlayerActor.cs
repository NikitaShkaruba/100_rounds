using HumbleObjects;
using HumbleObjects.Movement;
using UnityEngine;

namespace Actors {
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    [RequireComponent(typeof(DieBehaviour))]
    [RequireComponent(typeof(MoveInArenaBehaviour))]
    public class PlayerActor : MonoBehaviour {
        private DieBehaviour dieBehaviour;
        private MoveInArenaBehaviour moveInArenaBehaviour;
        private PlayerControllable playerControllable;

        public void Awake() {
            playerControllable = new PlayerControllable();

            dieBehaviour = gameObject.GetComponent<DieBehaviour>();
            moveInArenaBehaviour = gameObject.GetComponent<MoveInArenaBehaviour>();
        }

        public void Update() {
            playerControllable.UpdatePlayerInput();
            Debug.Log("Player position: " + moveInArenaBehaviour.rigidbody.position);
        }

        public void FixedUpdate() {
            if (dieBehaviour.isDead) {
                moveInArenaBehaviour.StopMovement();
                return;
            }

            moveInArenaBehaviour.Move(playerControllable.GetMoveDirection());
        }

        public void OnTriggerEnter2D(Collider2D collider) {
            dieBehaviour.Process(collider);
        }
    }
}