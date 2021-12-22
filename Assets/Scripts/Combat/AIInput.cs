using System.Collections;
using UnityEngine;

namespace Aeropunk.Combat
{
    public class AIInput : GenericInput
    {
        float _shootingDelay = 2f;
        float _sinceLastShooting = Mathf.Infinity;

        void Update()
        {
            XValue = Random.Range(-10, 10);
            YValue = Random.Range(-10, 10);

            if (_sinceLastShooting > _shootingDelay)
            {
                CanShoot = true;
                _sinceLastShooting = 0;
            }

            _sinceLastShooting += Time.deltaTime;
        }
    }
}