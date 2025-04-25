using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //Variables
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private InputAction moveAction, jumpAction;
    private int moveValue;
    private bool isJumping;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    void Update()
    {
        moveValue = moveAction.ReadValue<int>();
        isJumping = jumpAction.IsPressed();
        
    }

    //Player Movement
    private void FixedUpdate()
    {
        Debug.Log(moveValue);
        rb.linearVelocityX = moveValue;
    }
}
