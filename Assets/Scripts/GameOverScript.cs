using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text pointsText;
    public Blade bladeScript;

    public void Setup(){
        gameObject.SetActive(true);
        pointsText.text = bladeScript.score.ToString();
        Time.timeScale = 0f; // Pause Game
    }
    public void BackToMainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
