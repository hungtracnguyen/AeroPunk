using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Core
{
    public class RepeatingBackground : MonoBehaviour
    {
        [SerializeField] Transform _upperBackground = null;
        [SerializeField] float _outOfCameraPosition; // should be -22.5
        private Vector3 _upperBackgroundPosition; 

        private void Start()
        {
            if(_upperBackground != null)
            {
                _upperBackgroundPosition = _upperBackground.position;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.y <= _outOfCameraPosition)
            {
                RelocateBackground();
            }
        
        }

        private void RelocateBackground()
        {
            transform.position = _upperBackgroundPosition;
        }
    }

}