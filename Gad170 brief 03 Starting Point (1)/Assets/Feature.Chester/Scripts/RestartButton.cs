using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChesterRocela
{
    public class RestartButton : MonoBehaviour
    {
        public void ResetTheGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            Debug.Log("It works");
        }
    }
}
