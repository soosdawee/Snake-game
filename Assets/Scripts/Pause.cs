using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseBackground;

    public void Pressed()
    {
        PauseBackground.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseBackground.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
