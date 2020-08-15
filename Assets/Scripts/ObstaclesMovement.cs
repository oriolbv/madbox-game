using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public GameObject[] MovePoints;
    public GameObject Player;
    int current = 0;
    public float speed;
    float WPradius = 1;

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
        transform.position = Vector3.MoveTowards(transform.position, MovePoints[current].transform.position, Time.deltaTime * speed);

    }

    //void OnTriggerEnter(Collider n)
    //{
    //    if (n.gameObject == player)
    //    {
    //        player.transform.parent = transform;
    //    }
    //}
    //void OnTriggerExit(Collider n)
    //{
    //    if (n.gameObject == player)
    //    {
    //        player.transform.parent = null;
    //    }
    //}
}
