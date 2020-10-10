﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Target object position
    [Header("Target Object")]
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if target position on the y axis is greater
        // than the camera position
        if(target.position.y > transform.position.y){
            //the camera will follow the target's position
            transform.position = new Vector3(target.transform.position.x, 
            target.transform.position.y, transform.position.z);
        }
    }
}
