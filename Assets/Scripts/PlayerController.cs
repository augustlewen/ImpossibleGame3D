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
      transform.Translate(0, 0, moveSpeed * Time.deltaTime);

      if (Input.GetKeyDown(jumpKey) && IsTouchingGround())
      {
         GetComponent<Rigidbody>().AddForce(0, jumpForce, 0);
      }
   }

   bool IsTouchingGround()
   {
      int layerMask = LayerMask.GetMask("Ground");
      return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
   }
    
}
