﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Platform gameobject
    [Header("Platform Object")]
    public GameObject platform;
    //Default position for platform
    float pos = 0;
    //Game over canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        //Integer i equals 1000
        for(int i=0; i<1000; i++)
            //Execute SpawnPlatforms
            SpawnPlatforms();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Spawn platforms function
    void SpawnPlatforms(){
        //Spawn platforms randomly on the x axis
        //and place them on the y axis every 2.5
        //Vectors = a position on the scene
        //Vector(x,y,z) positions
        //f = float (specifying the value is a decimal)
        Instantiate(platform, new Vector3(Random.value*10 - 5f,
        pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }

    //Game over function
    public void GameOver(){
        //Game over canvas is active
        gameOverCanvas.SetActive(true);
    }
}
