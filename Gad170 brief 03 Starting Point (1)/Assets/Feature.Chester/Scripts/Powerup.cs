using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ChesterRocela
{
    public class Powerup : MonoBehaviour
    {
        public float multiplier = 2f;
        public float duration = 4f;
        public float normalSizetank = 5f;

        void OnTriggerEnter(Collider other)
        {
            // calling out "player" tag 
            if (other.CompareTag("Player"))
            {
                //function to start 
                StartCoroutine(Pickup(other));
            }
        }
        IEnumerator Pickup(Collider player)
        {
            //call out when player picks up Powerup
            Debug.Log("BIG MAN!!"); 

            //calling from playerstats script 
            PlayerStats stats = player.GetComponent<PlayerStats>();

            // disabling meshrenderer and collider on gameobject
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            
            // changing player scale when picking up powerup 
            // waiting for 5 second before it goes back to its normal size
            player.transform.localScale *= multiplier;

            yield return new WaitForSeconds(normalSizetank);

            player.transform.localScale /= multiplier;

            // increases player health when powerup has been triggered
            // and returning health back to its normal health
            stats.health *= multiplier;

            yield return new WaitForSeconds(duration);

            stats.health /= multiplier;

            // destroying gameobject on pickup
            Destroy(gameObject);
        }
    }
}