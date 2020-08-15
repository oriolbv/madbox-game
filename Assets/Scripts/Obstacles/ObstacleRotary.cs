using UnityEngine;

/// <summary>
/// Controls the rotation of the obstacle
/// </summary>
public class ObstacleRotary : MonoBehaviour
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
