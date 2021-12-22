using System;
using System.Collections;
using UnityEngine;

namespace Aeropunk.Combat
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] GenericInput _input = null;
        [SerializeField] Bullet _bullet = null;

        [SerializeField] Transform _leftGun, _centerGun, _rightGun;

        private void Awake()
        {
            _input = GetComponent<GenericInput>();
        }
        void Update()
        {
            if (_bullet == null) return;

            if (_input.CanShoot)
            {
                Shoot();
                _input.CanShoot = false;
            }
        }
        private void Shoot()
        {
            if(_bullet.GetLines() == 1)
            {
            Instantiate(_bullet.GetBulletPrefab(), _centerGun.position, transform.rotation);
            } else if (_bullet.GetLines() == 2)
            {
            Instantiate(_bullet.GetBulletPrefab(), _leftGun.position, transform.rotation);
            Instantiate(_bullet.GetBulletPrefab(), _rightGun.position, transform.rotation);
            } else
            {
            Instantiate(_bullet.GetBulletPrefab(), _leftGun.position, transform.rotation);
            Instantiate(_bullet.GetBulletPrefab(), _centerGun.position, transform.rotation);
            Instantiate(_bullet.GetBulletPrefab(), _rightGun.position, transform.rotation);
            }
        }

        public void SetBullet(Bullet bullet)
        {
            _bullet = bullet;

        }
    }
}