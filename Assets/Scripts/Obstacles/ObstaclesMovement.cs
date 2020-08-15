using UnityEngine;

/// <summary>
/// Movements of the different obstacles using infinite move points
/// </summary>
public class ObstaclesMovement : MonoBehaviour
{
    [Header("Move Points")]
    public GameObject[] MovePoints;
    
    [Header("Physics")]
    public float Speed;

    // Internal Variables
    private int current = 0;
    private float WPradius = 1;

    void Update()
    {
        if (Vector3.Distance(MovePoints[current].transform.position, transform.position) < WPradius)
        {
            current = Random.Range(0, MovePoints.Length);
            if (current >= MovePoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, MovePoints[current].transform.position, Time.deltaTime * Speed);

    }
}
