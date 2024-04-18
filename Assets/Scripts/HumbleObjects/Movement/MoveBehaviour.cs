using System;
using Shared;
using UnityEngine;

namespace HumbleObjects.Movement {
    [RequireComponent(typeof(Rigidbody2D))]
    public class MoveBehaviour : MonoBehaviour {
        [HideInInspector] public new Rigidbody2D rigidbody;
        public float speed;

        public void Start() {
            rigidbody = gameObject.GetComponent<Rigidbody2D>();
        }

        public void StopMovement() {
            rigidbody.velocity = new Vector2(0, 0);
        }

        public void Move(Direction direction) {
            rigidbody.velocity = ComputeVelocity(direction);
        }

        protected virtual Vector2 ComputeVelocity(Direction direction) {
            return direction switch {
                Direction.Up => new Vector2(0, speed),
                Direction.UpRight => new Vector2(speed, speed),
                Direction.Right => new Vector2(speed, 0),
                Direction.RightDown => new Vector2(speed, -speed),
                Direction.Down => new Vector2(0, -speed),
                Direction.DownLeft => new Vector2(-speed, -speed),
                Direction.Left => new Vector2(-speed, 0),
                Direction.LeftUp => new Vector2(-speed, speed),
                Direction.None => new Vector2(0, 0),
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
            };
        }
    }
}