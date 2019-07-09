using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherWall : MonoBehaviour
{

    public float speed = 1.0f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(36, 0, 4);
        pointB = new Vector3(39, 0, 4);
    }

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
