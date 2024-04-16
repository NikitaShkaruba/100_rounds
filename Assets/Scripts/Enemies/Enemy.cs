using UnityEngine;

namespace Enemies {
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Enemy : MonoBehaviour {
        protected new Rigidbody2D rigidbody;

        public void Start() {
            rigidbody = gameObject.GetComponent<Rigidbody2D>();
        }

        public void OnBecameInvisible() {
            Destroy(gameObject);
        }
    }
}