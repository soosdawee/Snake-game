using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
    private Text ScoreText;

    private void Awake()
    {
        ScoreText = transform.Find("ScoreText").GetComponent<Text>();

        Score.HighScoreChanged += Score_HighScoreChanged;
        UpdateHighScore();
    }

    private void Score_HighScoreChanged(object sender, System.EventArgs e)
    {
        UpdateHighScore();
    }

    private void Update()
    {
        ScoreText.text = Score.GetScore().ToString();
    }

    private void UpdateHighScore()
    {
        int highscore = Score.HighScore();
        transform.Find("HighScoreText").GetComponent<Text>().text = "REKORD:\n" + highscore.ToString();
    }
}
