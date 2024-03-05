using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform FollowTarget;
    [SerializeField] private Vector3 differance;

    private void LateUpdate()
    {
        transform.position = FollowTarget.position + differance;
        transform.LookAt(FollowTarget);
    }
}
