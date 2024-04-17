﻿using System;
using Shared;
using UnityEngine;

namespace HumbleObjects {
    [RequireComponent(typeof(ParticleSystem))]
    public class ArenaSprintBehaviour : MonoBehaviour {
        public float speed = 3f;

        private new ParticleSystem particleSystem;

        public void Start() {
            particleSystem = GetComponent<ParticleSystem>();
        }

        public void Initialize(Direction moveDirection) {
            var shape = particleSystem.shape;
            shape.position = GetEffectPosition(moveDirection);
            shape.rotation = GetEffectRotation(moveDirection);
        }

        public void ProcessCollision(Collider2D collider) {
            if (!collider.name.Equals("Arena")) {
                return;
            }

            speed *= 2;
            particleSystem.Play();
        }

        private static Vector3 GetEffectPosition(Direction moveDirection) {
            const float startingPosition = 0.1f;
            return moveDirection switch {
                Direction.Up => new Vector3(0, -startingPosition, 0),
                Direction.Right => new Vector3(-startingPosition, 0, 0),
                Direction.Down => new Vector3(0, startingPosition, 0),
                Direction.Left => new Vector3(startingPosition, 0, 0),
                _ => throw new Exception("sprint effect position is not supported for this direction")
            };
        }

        private static Vector3 GetEffectRotation(Direction moveDirection) {
            const float rotation = 90f;
            return moveDirection switch {
                Direction.Up => new Vector3(rotation, 0, 0),
                Direction.Right => new Vector3(0, -rotation, 0),
                Direction.Down => new Vector3(-rotation, 0, 0),
                Direction.Left => new Vector3(0, rotation, 0),
                _ => throw new Exception("sprint effect rotation is not supported for this direction")
            };
        }
    }
}