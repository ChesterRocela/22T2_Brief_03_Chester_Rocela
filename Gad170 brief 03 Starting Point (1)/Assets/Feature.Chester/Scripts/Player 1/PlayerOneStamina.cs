using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOneStamina : MonoBehaviour
{
    public Slider playOneStaminaBar;

    private int maxStamina = 200;
    private int currentStamina;

    private WaitForSeconds regenTick = new WaitForSeconds(0.3f);
    private Coroutine regen;

    public static PlayerOneStamina instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //currentstamina becomes 200 
        currentStamina = maxStamina;

        //setting slider to maxvalue to 200
        playOneStaminaBar.maxValue = maxStamina;
        playOneStaminaBar.value = maxStamina;

    }
    public void UseStamina(int amount)
    {
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            playOneStaminaBar.value = currentStamina;

            if (regen != null)
                StopCoroutine(regen);

            regen = StartCoroutine(RegenStamina());
        }
        else
        {
            Debug.Log("Not enough stamina");
        }
    }
    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(1f);

        while(currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 100;
            playOneStaminaBar.value = currentStamina;
            yield return regenTick;
        }
        regen = null;
    }
} 
