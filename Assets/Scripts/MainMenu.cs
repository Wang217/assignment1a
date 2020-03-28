using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

// Open Buttons
    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

public void OpenStore() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }

public void OpenLeaderboard() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
    }

// Return Buttons

public void GameBackToMain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

public void StoreBackToMain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

public void LeaderboardBackToMain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
}
