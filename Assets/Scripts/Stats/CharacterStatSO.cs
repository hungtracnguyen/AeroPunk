using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Stat
{
    [CreateAssetMenu(fileName = "Stat", menuName = "CreateStat/NewStat")]
    public class CharacterStatSO : ScriptableObject
    {
        public float Health;

        public float Strength;

        public float FireRate;
    }

}