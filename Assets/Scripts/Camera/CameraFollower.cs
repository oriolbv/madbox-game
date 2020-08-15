using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the camera movement
/// </summary>
public class CameraFollower : MonoBehaviour
{
    [Tooltip("Target object for the camera")]
    public Transform target;

    [Tooltip("Offset of camera with target")]
    public Vector3 offset = new Vector3(2, 4, 5);

    void Update()
    {
        // Check if target is a valid object 
        if (target != null)
        {
            // Set camera position and rotation to the target
            transform.position = target.position + offset;
            transform.LookAt(target);
        }

    }
}
