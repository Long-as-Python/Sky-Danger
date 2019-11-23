using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public float mouseSense = 100f;

    public Transform playerbody;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        playerbody.Rotate(Vector3.up * mouseX);

        Vector3 move = transform.right * x + transform.forward * z;
        

        controller.Move(move * speed * Time.deltaTime);
    }
}
