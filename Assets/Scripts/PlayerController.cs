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
      GetComponent<Rigidbody>().angularVelocity = new Vector3(8f, 0, 0);

      transform.Translate(0, 0, moveSpeed * Time.deltaTime, relativeTo:Space.World);

      if (Input.GetKeyDown(jumpKey) && IsTouchingGround())
      {
         Rigidbody rigidbody = GetComponent<Rigidbody>();
         rigidbody.AddForce(0, jumpForce, 0);
         rigidbody.angularVelocity = new Vector3(15f, 0, 0);

      }
   }

   bool IsTouchingGround()
   {
      int layerMask = LayerMask.GetMask("Ground");
      return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
   }
    
}
