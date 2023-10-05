using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
   public int moveSpeed;
   public int jumpForce;
   public KeyCode jumpKey;


   private void Update()
   {
      Rigidbody rb = GetComponent<Rigidbody>();

      transform.Translate(0, 0, moveSpeed * Time.deltaTime);
      bool isKeyPressed = Input.GetKeyDown(jumpKey);

      if (isKeyPressed)
      {
         rb.AddForce(0, jumpForce, 0);
         Debug.Log(rb.velocity);
      }
   }
    
}
