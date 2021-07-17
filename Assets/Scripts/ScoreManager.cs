using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text _score;
    [SerializeField] private Text _highScore;
    public static int _scoreCounter;
    private static int _highScoreCounter;

    void Start()
    {
        _scoreCounter = 0;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            _highScoreCounter = PlayerPrefs.GetInt("HighScore");
        }
    }

    void Update()
    {
        _score.text = _scoreCounter.ToString();
        _highScore.text = _highScoreCounter.ToString();
    }

    public static void HighScore()
    {
        if (_scoreCounter > _highScoreCounter)
        {
            _highScoreCounter = _scoreCounter;
        }

        PlayerPrefs.SetInt("HighScore", _highScoreCounter);
    }
}
