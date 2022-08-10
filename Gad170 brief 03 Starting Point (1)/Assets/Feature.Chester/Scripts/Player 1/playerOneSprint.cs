using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerOneSprint : MonoBehaviour
{
    Tank tanks;
   [SerializeField] private PlayerOneStamina playerOneStamina;
    private float normalspeed;
    private float sprintspeed;

    void Start()
    {
        playerOneStamina.playOneStaminaBar.value = 200f;

        tanks = GetComponent<Tank>();

        //current speed is 8, normal speed becomes 8 
        normalspeed = tanks.tankMovement.speed;
        //sprint speed becomes 16
        sprintspeed = normalspeed * 2;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            tanks.tankMovement.speed = sprintspeed;
            
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerOneStamina.playOneStaminaBar.value -= 0.1f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {

            tanks.tankMovement.speed = normalspeed;
        }
      
    }
}