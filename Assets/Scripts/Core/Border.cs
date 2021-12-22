using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aeropunk.Core
{
    public class Border : MonoBehaviour
    {
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Vector3 currentPos = collision.transform.position;
                collision.transform.position = currentPos;
                //Destroy(collision.gameObject);
            }
        }
    }
}