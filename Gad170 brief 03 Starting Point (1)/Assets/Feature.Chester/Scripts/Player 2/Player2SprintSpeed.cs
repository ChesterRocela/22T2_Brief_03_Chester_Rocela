using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2SprintSpeed : MonoBehaviour
{
    Tank cm;
    private float normalspeed;
    private float Sprintspeed;

    void Start()
    {
        cm = GetComponent<Tank>();
        normalspeed = cm.tankMovement.speed;
        Sprintspeed = normalspeed * 2;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.RightShift))
        {
            cm.tankMovement.speed = Sprintspeed;
        }
    }
}

