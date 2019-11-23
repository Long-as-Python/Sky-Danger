using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowYou : MonoBehaviour
{
    public Transform PlayerTransform;

    public Vector3 cameraOffset;

    [Range(0.01f,1.0f)]
    public float Smoothness;
    void Start()
    {
        cameraOffset = transform.position - PlayerTransform.position;
    }

    void LateUpdate()
    {
        Vector3 newVec3 = PlayerTransform.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newVec3, Smoothness);
    }
}
