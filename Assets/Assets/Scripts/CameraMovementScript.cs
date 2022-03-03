using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraMovementScript : MonoBehaviour
    {
        public float speed = 0.5F;
        
        private Vector3 current;
        private Vector3 _anker = Vector3.zero;

        private Camera _camera;

        private void Start()
        {
            _camera = GetComponent<Camera>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                current = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(0)) return;
            //deltaZ = 0
            Vector3 deltaInput = Input.mousePosition - current;
            deltaInput.Normalize();

            Vector3 move = new Vector3(0, deltaInput.x * speed, 0);//-deltaInput.y * speed);
            
            _camera.transform.RotateAround(_anker, move, speed);
        }
    }
}