using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ChesterRocela
{
    public class GameTextCanvas : MonoBehaviour
    {
        public float preGameWaitTime = 3f;
        private List<Tank> allTanksSpawnedIn = new List<Tank>();

        private int playerOneScore;
        private int playerTwoScore;
        private int PlayerThreeScore;
        private int PlayerFourScore;
        private void UpdateScores()
        {
            for(int i =0; i<allTanksSpawnedIn.Count; i++)
            {
                switch (allTanksSpawnedIn[i].playerNumber)
                {
                    case PlayerNumber.One:
                        {
                            TankGameEvents.OnScoreUpdatedEvent?.Invoke(allTanksSpawnedIn[i].playerNumber, playerOneScore);
                            break;
                        }
                    case PlayerNumber.Two:
                        {
                            TankGameEvents.OnScoreUpdatedEvent?.Invoke(allTanksSpawnedIn[i].playerNumber, playerTwoScore);
                            break;
                        }
                    case PlayerNumber.Three:
                        {
                            TankGameEvents.OnScoreUpdatedEvent?.Invoke(allTanksSpawnedIn[i].playerNumber, PlayerThreeScore);
                            break;
                        }
                    case PlayerNumber.Four:
                        {
                            TankGameEvents.OnScoreUpdatedEvent?.Invoke(allTanksSpawnedIn[i].playerNumber, PlayerFourScore);
                            break;
                        }
                }
            }
        }
        void Start()
        {
            StartCoroutine(GameLogic());    
        }
        private void ResetRound()
        {
            TankGameEvents.OnRoundResetEvent?.Invoke();
            TankGameEvents.SpawnTanksEvent(2);
            Invoke("Begin", 2);
        }

        private void BeginRound()
        {
            TankGameEvents.OnGameStartedEvent?.Invoke();
        }

        private IEnumerator GameLogic()
        {
            TankGameEvents.OnResetGameEvent?.Invoke();
            TankGameEvents.OnPreGameEvent?.Invoke();
            TankGameEvents.SpawnTanksEvent(2);
            yield return new WaitForSeconds(preGameWaitTime);
            TankGameEvents.OnGameStartedEvent?.Invoke();

            yield return null;
        }
    }
}
