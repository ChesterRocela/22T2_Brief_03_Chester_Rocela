using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Sprint : MonoBehaviour
{
    Tank tanks;
    private float normalspeed;
    private float sprintspeed;

    void Start()
    {
        tanks = GetComponent<Tank>();
        normalspeed = tanks.tankMovement.speed;
        sprintspeed = normalspeed * 2;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            tanks.tankMovement.speed = sprintspeed;
            
        }
    }
}