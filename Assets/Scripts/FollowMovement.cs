using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    public GameObject master;

    Vector3 deltaPosition;
    Vector3 slaveInitialPostion;


    void Start()
    {
        slaveInitialPostion = transform.position;
        deltaPosition = transform.position - master.transform.position;
    }

    void Update()
    {
        transform.rotation = master.transform.rotation;
        transform.position = master.transform.position * 2 + deltaPosition * 2 - slaveInitialPostion;

        transform.localScale = master.transform.localScale * 2;

        Debug.Log(slaveInitialPostion);

    }
}
