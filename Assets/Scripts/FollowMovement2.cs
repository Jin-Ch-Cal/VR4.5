using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement2 : MonoBehaviour
{
    public GameObject master;

    public Vector3 deltaPosition;


    void Start()
    {
        deltaPosition = transform.position - master.transform.position;
    }

    void Update()
    {
        transform.rotation = master.transform.rotation;
        transform.position = master.transform.position + deltaPosition;

        transform.localScale = master.transform.localScale * 250;

    }
}
