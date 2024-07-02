using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TMP_Text timerText;
    private float gameTime = 180f;
    private bool gameActive = false;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActive)
        {
            gameTime -= Time.deltaTime;
            UpdateTimerDisplay();

            if (gameTime <= 0)
                EndGame();
        }
    }

    private void EndGame()
    {
        gameActive = false;
        // Determine winner and display result
    }


    private void StartGame()
    {
        gameActive = true;
       // player1.score = 0;
      //  player2.score = 0;
      //  UpdateScoreDisplay();
    }



    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(gameTime / 60);
        int seconds = Mathf.FloorToInt(gameTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
