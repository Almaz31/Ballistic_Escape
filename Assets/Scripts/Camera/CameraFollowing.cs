using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Transform player;
    [SerializeField] private float distance = 5.0f;
    [SerializeField] private float height = 2.0f;

    void LateUpdate()
    {
        if (target == null)
        {
            return; 
        }

        Vector3 desiredPosition = player.position - target.forward * distance + Vector3.up * height;

        transform.position = desiredPosition;

        transform.forward = target.forward;
        transform.LookAt(target.position);
    }
}

