using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
   public Blade bladeScript;
   [SerializeField] private Text scoreText;

    private void Update()
    {
        scoreText.text = "Score: "+ bladeScript.score;
    }
}
