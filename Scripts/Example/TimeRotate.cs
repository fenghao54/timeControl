using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRotate : TimeBehaviour
{
    public Vector3 Direction
    {
        get { return direction; }
        set { direction = value; }
    }
    /*
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }*/

    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;

    public override void UpdateTime(float deltaTime)
    {
        Debug.Log("1");
        transform.Rotate(transform.up, speed * deltaTime);
    }
}
