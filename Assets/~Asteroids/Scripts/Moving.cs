﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Moving : MonoBehaviour
    {
        public float accceleration = 5f;
        public float rotationSpeed = 3f;
        public float maxVelocity = 5f;

        private Rigidbody2D rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            LimitVelocity();
        }
        void LimitVelocity()
        {
            Vector3 vel =rigid.velocity;
            if(vel.magnitude > maxVelocity)
            {
                vel = vel.normalized * maxVelocity;
            }
            rigid.velocity = vel; 
        }

        public void Accelerate(Vector3 direction)
        {
            rigid.AddForce(direction * accceleration);
        }
        public void RotateLeft()
        {
            rigid.rotation += rotationSpeed * Time.deltaTime;
        }
        public void RotateRight()
        {
            rigid.rotation -= rotationSpeed * Time.deltaTime;
        }
    }
}


