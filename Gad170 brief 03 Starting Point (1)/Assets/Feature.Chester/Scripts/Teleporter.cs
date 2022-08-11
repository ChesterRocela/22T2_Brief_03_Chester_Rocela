using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class Teleporter : MonoBehaviour
    {
        [SerializeField] public Transform teleport_1;
        private Transform teleport_2;
        [SerializeField] public GameObject playerOne;
        [SerializeField] public GameObject playerTwo;

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.CompareTag("Player 1"))
            {
                playerOne.transform.position = teleport_1.transform.position;

                playerOne.transform.position = teleport_2.transform.position;
            }
            if (collision.gameObject.CompareTag("Player 2"))
            {
                playerTwo.transform.position = teleport_1.transform.position;

                playerTwo.transform.position = teleport_2.transform.position;
            }
        
        }
        

    }
}
