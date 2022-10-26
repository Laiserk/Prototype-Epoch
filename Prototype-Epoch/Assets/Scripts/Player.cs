using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const int Speed = 5;

    private bool jumpWasPressed;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpWasPressed = true;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.position += movement * (Speed * Time.deltaTime);

        if (!jumpWasPressed) return;
        
        _rigidbody.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        jumpWasPressed = false;

    }
}
