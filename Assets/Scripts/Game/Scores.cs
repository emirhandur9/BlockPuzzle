using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int currentScores;
    private void Start()
    {
        currentScores = 0;
        UpdateScoreText();
    }
    private void OnEnable()
    {
        GameEvents.AddScore += AddScore;
    }

    private void OnDisable()
    {
        GameEvents.AddScore -= AddScore;
    }

    private void AddScore(int scores)
    {
        currentScores += scores;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = currentScores.ToString();
    }
}
