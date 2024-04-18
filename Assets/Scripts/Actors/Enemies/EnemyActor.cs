using UnityEngine;

namespace Actors.Enemies {
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    public abstract class EnemyActor : MonoBehaviour {
        public void OnBecameInvisible() {
            Destroy(gameObject);
        }
    }
}