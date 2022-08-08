using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ChesterRocela
{
    public class GameUIManager : MonoBehaviour
    {
        public GameObject StartText;
        public GameObject IngameUi;
        public GameObject Endtext;

        public List<InGamePlayerUI> allplayerui = new List<InGamePlayerUI>();

        private void OnEnable()
        {
            TankGameEvents.OnPreGameEvent += PreGame;
            TankGameEvents.OnGameStartedEvent += Ingame;
            TankGameEvents.OnRoundEnededEvent += PostRound;
            TankGameEvents.OnTanksSpawnedEvent += Displayerscore;



        }
        private void OnDisable()
        {
            TankGameEvents.OnPreGameEvent += PreGame;
            TankGameEvents.OnGameStartedEvent += Ingame;
            TankGameEvents.OnRoundEnededEvent += PostRound;
            TankGameEvents.OnTanksSpawnedEvent += Displayerscore;
        }
        private void PreGame()
        {
            StartText.SetActive(true);
            IngameUi.SetActive(false);
            Endtext.SetActive(false);
        }
        private void Ingame()
        {
            StartText.SetActive(false);
            IngameUi.SetActive(true);
            Endtext.SetActive(false);
        }
        private void Displayerscore(List<GameObject> alltanks)
        {
            for(int i =0; i < allplayerui.Count; i++)
            {
                if (!alltanks[i].GetComponent<Tank>())
                {
                    continue;
                }
                Tank tank = alltanks[i].GetComponent<Tank>();
                for(int j=0; j <allplayerui.Count; j++)
                {
                    allplayerui[j].EnableText(tank.playerNumber);
                }
            }
        }
        private void PostRound(PlayerNumber playerNumber)
        {
            StartText.SetActive(false);
            IngameUi.SetActive(false);
            Endtext.SetActive(true);
            Endtext.GetComponentInChildren<Text>().text = "Player " + playerNumber.ToString() + " Wins!";
        }
    }
}

