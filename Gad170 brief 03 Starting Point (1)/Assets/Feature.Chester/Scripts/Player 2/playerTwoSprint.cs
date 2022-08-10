using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerTwoSprint : MonoBehaviour
{
    Tank tanks;
    [SerializeField] private PlayerTwoStamina playerTwoStamina;
    public float normalspeed;
    private float Sprintspeed;

    void Start()
    {
        playerTwoStamina.playerTwoStaminaBar.value = 200f;

        tanks = GetComponent<Tank>();
       
        // current speed is 8
        // normal speed becomes 8
        normalspeed = tanks.tankMovement.speed;
       
        //sprint speed becomes 16
        Sprintspeed = normalspeed * 2;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {

            tanks.tankMovement.speed = Sprintspeed;

        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            playerTwoStamina.playerTwoStaminaBar.value -= 0.1f;
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {

            tanks.tankMovement.speed = normalspeed;

        }
       
        
    }
}

