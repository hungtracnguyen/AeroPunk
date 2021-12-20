using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] PlayerInput playerInput = null;
    [SerializeField] float movingSpeed = 5f;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movement = new Vector3(playerInput.XValue, playerInput.YValue, 0);
        transform.Translate(movement * Time.deltaTime * movingSpeed); // local moving
        //transform.position += movement; //world moving

    }
}
