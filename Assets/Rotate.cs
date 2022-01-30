using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            var rotation = transform.eulerAngles;
            rotation.x += 0.2f;
            transform.eulerAngles = rotation;
        }
        if (Input.GetKey(KeyCode.A))
        {
            var rotation = transform.eulerAngles;
            rotation.z += 0.2f;
            transform.eulerAngles = rotation;
        }
        if (Input.GetKey(KeyCode.S))
        {
            var rotation = transform.eulerAngles;
            rotation.x -= 0.2f;
            transform.eulerAngles = rotation;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var rotation = transform.eulerAngles;
            rotation.z -= 0.2f;
            transform.eulerAngles = rotation;
        }
    }
}
