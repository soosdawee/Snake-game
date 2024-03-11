using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Score 
{
    public static int score;

    public static event EventHandler HighScoreChanged;

    public static void InitializeStatic()
    {
        HighScoreChanged = null;
        score = 0;
    }

    public static int GetScore()
    {
        return score;
    }

    public static void AddScore()
    {
        score += 100;
    }

    public static int HighScore()
    {
        return PlayerPrefs.GetInt("highscore", 0);
    }

    public static bool TryNewHighScore()
    {
        return TryNewHighScore(score);
    }

        public static bool TryNewHighScore(int score)
    {
        int highscore = HighScore();

        if (score > highscore)
        {
            PlayerPrefs.SetInt("highscore", score);
            PlayerPrefs.Save();
            if (HighScoreChanged != null) HighScoreChanged(null, EventArgs.Empty);
            return true;
        }
        else return false;
    }
}
