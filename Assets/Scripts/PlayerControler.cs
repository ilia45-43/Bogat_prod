using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float speed;

    //private Vector3 lerpMovement;
    //private Vector3 movement;

    //[SerializeField]
    //private float smooth;

    //private CharacterController characterController;
    //private void Awake()
    //{
    //    characterController = GetComponent<CharacterController>();
    //}
    void Update()
    {
        //float vertical = Input.GetAxis("Vertical");
        //float horizontal = Input.GetAxis("Horizontal");

        //Vector3 forward = transform.forward * vertical;
        //Vector3 direction = transform.right * horizontal;

        //movement = (forward + direction) * speed;
        //lerpMovement = Vector3.Lerp(lerpMovement, movement, smooth);

        //characterController.Move(lerpMovement * Time.deltaTime);


        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.forward, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.forward, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.right, speed * Time.deltaTime);
        }
    }
}
