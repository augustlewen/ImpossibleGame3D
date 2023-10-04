using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic_Rotation : MonoBehaviour
{
    
    public int rotationSpeed;

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
