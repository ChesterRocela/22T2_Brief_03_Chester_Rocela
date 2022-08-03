using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[Serializable]
public class TankManager 
{
   /* public Color playercolor;
    public Transform m_spawnpoint;
    [HideInInspector] public int playernumber;
    [HideInInspector] public string coloredplayertext;
    [HideInInspector] public GameObject instance;
    [HideInInspector] public int wins;

    private TankMovement movement;
    private TankControls controls;
    private GameObject canvasgameobject;

    public void setup()
    {
        movement = instance.GetComponent<TankMovement>();
        controls = instance.GetComponent<TankControls>();
        canvasgameobject = instance.GetComponentInChildren<Canvas>().gameObject;

        movement.playernumber = playernumber;
        controls.playernumber = playernumber;

        coloredplayertext = "<color=#" + ColorUtility.ToHtmlStringRGB(playercolor) + ">PLAYER " + playernumber + "</color>";

        MeshRenderer[] renderers = instance.GetComponentInChildren<MeshRenderer>();

        for(int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material.color = playercolor;
        }
    }
    
    public void DisableControl()
    {
        movement.enabled = false;
        controls.enabled = false;

        canvasgameobject.SetActive(false);
    }
    public void EnabledControl()
    {
        movement.enabled = true;
        controls.enabled = true;

        canvasgameobject.SetActive(true);
    }
    public void Reset()
    {
        instance.transform.position = m_spawnpoint.position;
        instance.transform.position = m_spawnpoint.rotation;

        instance.SetActive(false);
        instance.SetActive(true);
    }
    */
}
