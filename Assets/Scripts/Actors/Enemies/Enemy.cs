using HumbleObjects.Movement;
using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    [RequireComponent(typeof(OneDirectionMoveBehaviour))]
    public abstract class Enemy : MonoBehaviour {
        public void OnBecameInvisible() {
            Destroy(gameObject);
        }
    }
}