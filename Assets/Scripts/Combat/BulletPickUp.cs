using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Combat
{

    public class BulletPickUp : MonoBehaviour
    {
        [SerializeField] Bullet _bullet;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<Attack>().SetBullet(_bullet);
                Destroy(gameObject);
            }
        }
    }
}
