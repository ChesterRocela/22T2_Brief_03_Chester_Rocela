using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ChesterRocela
{
    public class Powerup : MonoBehaviour
    {
        
        public float multiplier = 2f;
        public float durationPowerUp = 3f;

        public WaitForSeconds returnHealth = new WaitForSeconds(0.3f);

        private void OnTriggerEnter(Collider other)
        {
            // calling out "player" tag 
            if (other.CompareTag("Player"))
            {
                //function to start when player triggers powerup
                StartCoroutine(Pickup(other));

                other.GetComponent<Tank>().tankHealth.maxHealth += 100;
            }
        }
            
        IEnumerator Pickup(Collider player)
        {
            //call out when player picks up Powerup
            Debug.Log("MORE POWER MEANS GET BIGGER"); 

            //calling from playerstats script 
            PlayerStats stats = player.GetComponent<PlayerStats>();

            // disabling meshrenderer and collider on gameobject
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            // increases player health when powerup has been triggered
            //if player health is greater then 100, tank scale is multiplied by 2 
            stats.health *= multiplier;

            if (stats.health > 100)
            {
                player.transform.localScale *= multiplier;
            }

            // duration of how long the powerup till it fades 
            yield return new WaitForSeconds(durationPowerUp);

            //setting player health back to normal 
            //setting player scale size back to normal
            stats.health /= multiplier;

            player.transform.localScale /= multiplier;

            // destroying gameobject on pickup
            Destroy(gameObject);
        }
    }
}