using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int countDownValue = 16;
    public Blade bladeScript;
    public GameOverScript gameOverScript;
    
    [SerializeField] private Text TimerValue;
    int temp = 5;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    private void Update()
    {
        TimerValue.text = "Time: "+ countDownValue;
    }

    public void countDownTimer()
    {
        if(countDownValue>0)
        {
            if(bladeScript.score==temp)
            {
                countDownValue += 5;
                temp = bladeScript.score + 5;
            }
            countDownValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else{
            gameOverScript.Setup();
            Debug.Log("GameOver");
        }
    }
}
