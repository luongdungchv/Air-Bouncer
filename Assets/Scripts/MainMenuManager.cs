﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
