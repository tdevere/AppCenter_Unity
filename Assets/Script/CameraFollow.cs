﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float smoothness;
    public Transform targetObject;
    private Vector3 initalOffset;
    private Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        initalOffset = transform.position - targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        //cameraPosition = targetObject.position + initalOffset;
        //transform.position = cameraPosition;
        //Debug.Log(cameraPosition);
    }
}
