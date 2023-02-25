using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScoreSc : MonoBehaviour
{
    public float playerScore;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    void Start()
    {
        highScoreText.text = "HIGHEST SCORE: " + (PlayerPrefs.GetFloat("highScore")).ToString("0");
    }

    void Update()
    {
        playerScore += 5 * Time.deltaTime;
        scoreText.text = "SCORE: " + playerScore.ToString("0");
        if (playerScore> PlayerPrefs.GetFloat("highScore"))
        {
            PlayerPrefs.SetFloat("highScore", playerScore);
        }
    }
}
