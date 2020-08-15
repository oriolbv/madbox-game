using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls all the physics and animations of our character
/// </summary>
public class ObstacleRotatori : MonoBehaviour
{
    [Header("Physics")]
    public float SpinSpeed = 40f;
    public bool IsClockwise = true;

    // Update is called once per frame
    void Update()
    {
        int clockwise = (IsClockwise) ? 1 : -1;
        transform.Rotate(0, clockwise * SpinSpeed * Time.deltaTime, 0);
    }
}
