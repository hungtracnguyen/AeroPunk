using UnityEngine;

namespace Aeropunk.Combat
{
    public class PlayerInput : GenericInput
    {
        void Update()
        {
            XValue = Input.GetAxisRaw("Horizontal");
            YValue = Input.GetAxisRaw("Vertical");

            if (Input.GetButtonDown("Fire1"))
            {
                CanShoot = true;
            }
        }
    }
}
