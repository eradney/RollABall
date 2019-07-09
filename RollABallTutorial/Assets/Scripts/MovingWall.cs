using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 pointA;
    public Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(24, 0, -2);
        pointB = new Vector3(21, 0, -2);
    }

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}