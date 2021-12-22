using System.Collections;
using UnityEngine;

namespace Aeropunk.Combat
{
    [CreateAssetMenu(fileName = "Bullet", menuName = "CreateWeapon/New Bullet", order = 0)]
    public class Bullet : ScriptableObject
    {
        [SerializeField] GameObject _bulletPrefab = null;

        [SerializeField] [Range(1, 3)] int _lines;

        [SerializeField] float _damage;

        [SerializeField] float _speed;


        public GameObject GetBulletPrefab() => _bulletPrefab;
        public int GetLines() => _lines;
        public float GetDamage() => _damage;
        public float GetSpeed() => _speed;


    }
}