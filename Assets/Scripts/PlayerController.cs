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
   public int spinSpeed;

   private void FixedUpdate()
   {
      Rigidbody rigidbody = GetComponent<Rigidbody>();

      if(rigidbody.velocity.y < -0.1f)
         rigidbody.AddForce(0, -1, 0);
         
      rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, moveSpeed);
   }

   private void Update()
   {
      Rigidbody rigidbody = GetComponent<Rigidbody>();
      rigidbody.angularVelocity = new Vector3(spinSpeed, 0, 0);

      if (Input.GetKeyDown(jumpKey) && IsTouchingGround())
         Jump();
      
   }

   private void Jump()
   {
      Rigidbody rigidbody = GetComponent<Rigidbody>();

      rigidbody.AddForce(0, jumpForce, 0);
   }

   bool IsTouchingGround()
   {
      int layerMask = LayerMask.GetMask("Ground");
      return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
   }
    
}
