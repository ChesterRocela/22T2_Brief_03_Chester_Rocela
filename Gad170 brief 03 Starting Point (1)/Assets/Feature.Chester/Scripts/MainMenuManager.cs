using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChesterRocela
{
    public class MainMenuManager : MonoBehaviour
    {
        // references our panels 
        // set active/inactive when clicking certain buttons

        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private GameObject creditsPanel;

        public void StartButtonClick()
        {
            Debug.Log("Game is now Starting");
            
            SceneManager.LoadScene(1);
        }

        public void Backbuttonclick()
        {
            Debug.Log("Back Button Activated!");

            mainMenuPanel.SetActive(true);
            creditsPanel.SetActive(false);
        }

        public void CreditsButtonClick()
        {
            Debug.Log("Credits Button Activated!");

            mainMenuPanel.SetActive(false);
            creditsPanel.SetActive(true);
        }

        public void QuitbuttonClick()
        {
            Debug.Log("Game is now Quitting");

            Application.Quit();
        }
    }
}
