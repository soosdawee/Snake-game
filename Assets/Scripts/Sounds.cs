using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Sounds 
{
    public static void PlaySound()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.snakeDeath);
    }

    public static void PlaySound1()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.snakeEats);
    }
}
