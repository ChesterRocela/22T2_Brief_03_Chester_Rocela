using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class Powerup : MonoBehaviour
    {
        public float multiplier = 2f;
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pickup(other);
            }
        }
        void pickup(Collider player)
        {
            TankHealth stats = player.GetComponent<TankHealth>();

            stats.maxHealth *= multiplier;

            Destroy(gameObject); 
        }
    }
}