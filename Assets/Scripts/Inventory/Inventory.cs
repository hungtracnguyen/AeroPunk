using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Inventory
{
    public class Inventory : MonoBehaviour
    {
        #region Singleton
        public static Inventory instance;

        private void Awake()
        {
            if (instance != null)
            {
                Debug.Log("there are more than 1 inventory ");
                return;
            }

            instance = this;
        }

        #endregion

        

    }
}
