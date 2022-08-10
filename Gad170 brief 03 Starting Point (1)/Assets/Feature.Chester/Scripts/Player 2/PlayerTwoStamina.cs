using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoStamina : MonoBehaviour
{
    public Slider playerTwoStaminaBar;

    private int maxstamina = 200;
    private int currentstamina;

    private WaitForSeconds regentick = new WaitForSeconds(0.3f);
    private Coroutine regen;

    public static PlayerTwoStamina instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
    

        //currentstamina becomes 200
        currentstamina = maxstamina;
        
        //setting slider to maxvalue which is 200
        playerTwoStaminaBar.maxValue = maxstamina;
        playerTwoStaminaBar.value = maxstamina;
    }

    public void UseStamina(int amount)
    {
        if(currentstamina - amount >= 0)
        {
            currentstamina -= amount;
            playerTwoStaminaBar.value = currentstamina;
            

            if (regen != null)
            {
                StopCoroutine(regen);
            }

            regen = StartCoroutine(RegenStamina());
        }
        else
        {
            Debug.Log("Not enough Stamina");
        }
    }
    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(1f);

        while (currentstamina < maxstamina)
        {
            currentstamina += maxstamina / 100;
            playerTwoStaminaBar.value = currentstamina;
            yield return regentick;
        }
        regen = null;
    }
}

