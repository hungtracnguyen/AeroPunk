using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float XValue { get; private set; }
    public float YValue { get; private set; }

    void Update()
    {
        XValue = Input.GetAxisRaw("Horizontal");
        YValue = Input.GetAxisRaw("Vertical");
    }
}
