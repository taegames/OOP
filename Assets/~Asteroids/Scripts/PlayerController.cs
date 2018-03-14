using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerController : MonoBehaviour
    {
        public Moving movement;
        public Shooting shoot;

        #region Uniy Functions
        void Update()
        {
            Shoot();
            Movement();
        }
#endregion

        #region Custom Functions
        void Shoot()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shoot.Fire(transform.right);
            }
        }
        void Movement()
        {
            float inputV = Input.GetAxis("Vertical");
            // -1   == S || DownArrow
            //  0   == Not Pressed
            //  1   == W || UpArrow

            float inputH = Input.GetAxis("Horizontal");
            // -1   == A || LeftArrow
            //  0   == Not Pressed
            //  1   == D || RightArrow

            if (inputV > 0)
            {
                movement.Accelerate(transform.up);
            }

            // If inputH > 0
            if (inputH > 0)
            {
                // Rotate Right
                movement.RotateRight();
            }

            // If inputH < 0
            if (inputH < 0)
            {
                // Rotate Left
                movement.RotateLeft();
            }
        }
        #endregion
    }
}