using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameHandler : MonoBehaviour
{
    private static GameHandler instance;

    [SerializeField] private Snake snake;

    private LevelGrid levelGrid;

    private void Awake()
    {
        instance = this;
        Score.InitializeStatic();
        Time.timeScale = 1f;

        Score.TryNewHighScore(200);
    }

    private void Start()
    {
        Debug.Log("GameHandlerStart");

        levelGrid = new LevelGrid(20, 20);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

    public static void SnakeDied()
    {
        Score.TryNewHighScore();
    }
}
