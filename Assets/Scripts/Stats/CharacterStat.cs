using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Stat
{
    public class CharacterStat : MonoBehaviour
    {
        [SerializeField] private CharacterStatSO stat = null;
        private float _health;
        private float _strength;

        private void Start()
        {
            _health = stat.Health;
            _strength = stat.Strength;
        }

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
        
        public float GetStrength()
        {
            return _strength;
        }
    }
}
