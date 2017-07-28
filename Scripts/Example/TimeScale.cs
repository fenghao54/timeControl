using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : TimeBehaviour {

    public Vector3 Direction
    {
        get { return direction; }
        set { direction = value; }
    }

    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;

    public override void UpdateTime(float deltaTime)
    {
       
        transform.localScale+=new Vector3(1,1,1)*speed*deltaTime;
    }
}
