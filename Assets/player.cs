using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController _controller;
    public Collider _collider;
    public float _speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        //get input from the user
        //use wasd for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //move the player based on the input
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = direction * _speed;
        _controller.Move(velocity * Time.deltaTime);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("slow"))
        {
            _speed = 2.0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _speed = 5.0f; 
    }
}
