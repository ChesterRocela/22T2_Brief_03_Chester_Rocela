using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player2stamina : MonoBehaviour
{
    public Slider Play2Stamina;

    private int maxstamina = 300;
    private int currentstamina;

    private WaitForSeconds regentick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    public static player2stamina instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentstamina = maxstamina;
        Play2Stamina.maxValue = maxstamina;
        Play2Stamina.value = maxstamina;
    }
    public void UseStamina(int amount)
    {
        if(currentstamina - amount >= 0)
        {
            currentstamina -= amount;
            Play2Stamina.value = currentstamina;

            if (regen != null)
                StopCoroutine(regen);

            regen = StartCoroutine(RegenStamina());
        }
        else
        {
            Debug.Log("Not enough Stamina");
        }
    }
    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(2);
        
        while(currentstamina < maxstamina)
        {
            currentstamina += maxstamina / 100;
            Play2Stamina.value = currentstamina;
            yield return regentick;
        }
        regen = null;
    }
}

