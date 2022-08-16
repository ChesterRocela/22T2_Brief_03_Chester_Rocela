using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChesterRocela
{
    public class GameMenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject gameMenuPanel;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if(gameMenuPanel.activeSelf == true)
                {
                    HideGameMenuPanel();
                }
                else
                {
                    ShowGameMenuPanel();
                }
            }
        }

        public void ShowGameMenuPanel()
        {
            gameMenuPanel.SetActive(true);
        }

        public void HideGameMenuPanel()
        {
            gameMenuPanel.SetActive(false);
        }

        public void ResumeGameButton()
        {
            HideGameMenuPanel();
        }
        public void ResetTheGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        public void LoadScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}