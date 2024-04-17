using UnityEngine;

namespace HumbleObjects {
    [RequireComponent(typeof(ParticleSystem))]
    public class DieBehaviour : MonoBehaviour {
        [HideInInspector] public bool isDead;
        private ParticleSystem bloodParticleSystem;

        public void Start() {
            bloodParticleSystem = GetComponent<ParticleSystem>();
        }

        public void Process(Collider2D collider) {
            // Don't die second time
            if (isDead) {
                return;
            }

            if (!collider.name.Contains("Enemy")) {
                return;
            }

            isDead = true;
            bloodParticleSystem.Play();
            Debug.Log("U DED");
        }
    }
}