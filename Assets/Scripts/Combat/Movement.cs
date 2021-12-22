using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Combat
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] GenericInput _input = null;
        [SerializeField] float _movingSpeed = 5f;
        Rigidbody2D _myBody = null;

        private void Awake()
        {
            _myBody = GetComponent<Rigidbody2D>();
            _input = GetComponent<GenericInput>();
        }

        void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 movement = new Vector3(_input.XValue, _input.YValue, 0);
            //transform.Translate(movement * Time.deltaTime * movingSpeed); // local moving
            //transform.position += movement; //world moving
            _myBody.AddForce(movement * Time.deltaTime * _movingSpeed,
                ForceMode2D.Impulse); // local moving + rigid body calculated

        }
    }
}
