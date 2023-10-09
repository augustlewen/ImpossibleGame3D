using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class FollowPlayer : MonoBehaviour
    {
        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            if (player == null)
                return;
            Vector3 targetPosition = player.transform.position + new Vector3(0, 2.64f, -3.33f);
            transform.position = targetPosition;
        }
    }
}