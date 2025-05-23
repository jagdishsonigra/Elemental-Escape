using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;

    void Awake()
    {
        if (backgroundMusic == null && (SceneManager.GetActiveScene().name!="StoryScene" || 
        SceneManager.GetActiveScene().name!="DeathScene" || SceneManager.GetActiveScene().name!="DeathSceneLv2" || 
        SceneManager.GetActiveScene().name!="MenuScene"))
        {

            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        { Destroy(gameObject); }
    }
}