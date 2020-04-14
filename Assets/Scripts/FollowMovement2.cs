using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowMovement2 : MonoBehaviour
{
    public GameObject model;

    public UnityEngine.Vector3 deltaPosition;
    UnityEngine.Vector3 bInitialPostion;


    void Start()
    {
        bInitialPostion = transform.position;
        deltaPosition = transform.position - model.transform.position;
        
    }

    void Update()
    {
        transform.rotation = model.transform.rotation;
        transform.position = model.transform.position * 250 + deltaPosition * 250 - bInitialPostion * 249;

        transform.localScale = model.transform.localScale * 250;

    }
}
