using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;
    public float RotationSpeed = 50f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Vector3 point;
    
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(point, -Vector3.up, RotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(point, Vector3.up, RotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            transform.RotateAround(point, Vector3.right, RotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            transform.RotateAround(point, -Vector2.right, RotationSpeed * Time.deltaTime);
        }

        //if (direction.magnitude >= 0.1f)
        //{
        //    float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //    float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        //    transform.rotation = Quaternion.Euler(0f, angle, 0f);
        //    controller.Move(direction * speed * Time.deltaTime);
        //}
    }
}
