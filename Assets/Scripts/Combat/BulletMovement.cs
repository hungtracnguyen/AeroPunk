using Aeropunk.Stat;
using System;
using System.Collections;
using UnityEngine;

namespace Aeropunk.Combat
{
    public class BulletMovement : MonoBehaviour
    {
        [SerializeField] Bullet _bullet = null; 
        
        void Update()
        {
            MoveBullet();
        }

        private void MoveBullet()
        {
            Vector2 movement = new Vector2(0f, _bullet.GetSpeed());
            transform.Translate(movement);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // take damage if there is health component
            if (collision.GetComponent<CharacterStat>())
            {
            collision.GetComponent<CharacterStat>().TakeDamage(_bullet.GetDamage());
            }

            
            Destroy(gameObject);
        }
    }
}