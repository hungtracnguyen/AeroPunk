using UnityEngine;

namespace Aeropunk.Core
{
    public class MovingBackground : MonoBehaviour
    {
        [SerializeField] private float _speed;


        void Update()
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
    }
}