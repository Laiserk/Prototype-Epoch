using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation  : MonoBehaviour
{
    private float x;
    private float y;
    private Vector3 rotateValue;

    private void Update()
    {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");

        
        rotateValue = new Vector3(x, y * -1, 0);
        var transform1 = transform;
        transform1.eulerAngles -= rotateValue;
    }
}
