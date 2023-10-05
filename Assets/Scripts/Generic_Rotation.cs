using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Generic_Rotation : MonoBehaviour
{
    public int maxRotationSpeed;
    float rotationSpeed = 0;
    public float maxAngle;

    void Update()
    {
        rotationSpeed = Mathf.Lerp(rotationSpeed, maxRotationSpeed, 0.1f);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        
        if(transform.rotation.z < maxAngle && transform.rotation.z > -maxAngle)
            return;

        maxRotationSpeed = -maxRotationSpeed;
        rotationSpeed = 0;
    }
}
