using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;



public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] private float velocity = 10f;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private AudioSource walkSound;

    public void OnMovement(InputAction.CallbackContext move)
    {
        horizontal = move.ReadValue<Vector2>().x;
        vertical = move.ReadValue<Vector2>().y;

    }
    public void Interact(InputAction.CallbackContext interact)
    {
        if (interact.started)
        {
            Debug.Log("Interactuando.");
        }
    }
    public void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(horizontal * velocity, rigidbody.velocity.y, vertical * velocity);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            Walk();

        }
    }
    private void Walk()
    {
        walkSound.Play();
    }
}