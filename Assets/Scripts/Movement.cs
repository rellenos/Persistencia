using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;
    public Rigidbody rb;
    private float x, y;

    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }
}
