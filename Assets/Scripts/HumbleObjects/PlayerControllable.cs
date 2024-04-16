using Shared;
using UnityEngine;

namespace HumbleObjects {
    public class PlayerControllable {
        private float horizontalInput;
        private float verticalInput;

        public void UpdatePlayerInput() {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");
        }

        public Direction GetMoveDirection() {
            return horizontalInput switch {
                0 when verticalInput > 0 => Direction.Up,
                > 0 when verticalInput > 0 => Direction.UpRight,
                > 0 when verticalInput == 0 => Direction.Right,
                > 0 when verticalInput < 0 => Direction.RightDown,
                0 when verticalInput < 0 => Direction.Down,
                < 0 when verticalInput < 0 => Direction.DownLeft,
                < 0 when verticalInput == 0 => Direction.Left,
                < 0 when verticalInput > 0 => Direction.LeftUp,
                _ => Direction.None
            };
        }
    }
}