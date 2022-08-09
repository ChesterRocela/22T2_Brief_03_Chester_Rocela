using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Sprint : MonoBehaviour
{
    Tank cm;
    private float normalspeed;
    private float sprintspeed;

    void Start()
    {
        cm = GetComponent<Tank>();
        normalspeed = cm.tankMovement.speed;
        sprintspeed = normalspeed * 2;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cm.tankMovement.speed = sprintspeed;
            
        }
    }
}