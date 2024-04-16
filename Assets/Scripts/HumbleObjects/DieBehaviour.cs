using UnityEngine;

namespace HumbleObjects {
    public class DieBehaviour : MonoBehaviour {
        public void Process(Collider2D collider) {
            if (!collider.name.Contains("Enemy")) {
                return;
            }

            Debug.Log("U DED");
            Destroy(gameObject);
        }
    }
}