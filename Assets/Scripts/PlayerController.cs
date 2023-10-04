using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private void Update()
   {
      transform.Translate(0, 0, 5 * Time.deltaTime);
   }
}
