using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Generic_Rotation : MonoBehaviour
{
    public bool constantRotation;
    public int maxRotationSpeed;
    public float rotationSpeed = 0;
    public float maxAngle;
    
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        if(constantRotation)
            return;
        
        rotationSpeed = Mathf.Lerp(rotationSpeed, maxRotationSpeed, 0.1f);
        if(transform.rotation.z < maxAngle && transform.rotation.z > -maxAngle)
            return;

        maxRotationSpeed = -maxRotationSpeed;
        rotationSpeed = 0;
    }
}
