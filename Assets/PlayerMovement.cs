using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1000.0f;
    private Vector3 movement;

    private void OnMove(InputValue input)
    {
        Vector2 inputVec = input.Get<Vector2>();
        movement = new Vector3(inputVec.x, 0, inputVec.y);
    }

    private void FixedUpdate()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(movement * Time.fixedDeltaTime * speed);
    }
}
