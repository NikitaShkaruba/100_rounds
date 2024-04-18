using UnityEngine;

namespace HumbleObjects {
    public class ShootBehaviour : MonoBehaviour {
        [HideInInspector] public bool finishedShooting;
        public GameObject aimTarget;
        public float scaleShootingSpeed;
        public float attackMinScale;

        public void Shoot() {
            if (!aimTarget.activeSelf) {
                aimTarget.SetActive(true);
            }

            if (aimTarget.transform.localScale.x > attackMinScale &&
                aimTarget.transform.localScale.y > attackMinScale) {
                aimTarget.transform.localScale += new Vector3(-scaleShootingSpeed, -scaleShootingSpeed, 0);
            } else {
                finishedShooting = true;
            }
        }
    }
}