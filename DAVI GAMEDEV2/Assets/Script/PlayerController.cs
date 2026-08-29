using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rig;
    public Transform cannon;

    public float speed = 10;
    public Vector2 rotationSpeed = new Vector2(10, 10);
    public float minRotationX = -75f;
    public float maxRotation = 0f;

    private Vector2 moveInput;
    private Vector2 cannonRotation;

    public void Onmove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {

    }
    

}
