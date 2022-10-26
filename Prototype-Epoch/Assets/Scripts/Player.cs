using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const int Speed = 5;
    private bool _jumpWasPressed;
    private Rigidbody _rigidbody;
    
    [SerializeField]
    private Transform groundCheckTransform = null;
    

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
            _jumpWasPressed = true;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.position += movement * (Speed * Time.deltaTime);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length == 1) return;

        if (!_jumpWasPressed) return;
        
        _rigidbody.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        _jumpWasPressed = false;

    }
}
