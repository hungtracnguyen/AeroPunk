using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Stat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float _health = 100;

        public void TakeDamage(float damage)
        {
            _health -= damage;

            if(_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
        
    }
}
