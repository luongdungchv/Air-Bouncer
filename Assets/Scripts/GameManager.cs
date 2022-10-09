using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;
    public static Player player;

    public int score;
    public int highscore;

    public Text scoreText, highscoreText;

    public GameObject pausePanel;
    public GameObject losePanel;

    public TextMeshProUGUI finalScoreText, finalHighScoreText;

    public ParticleSystem deadFX;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        ins = this;
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        highscoreText.text = highscore.ToString();

       
    }
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
    }
    public void Lose()
    {
        StartCoroutine(GameOver());
    }
    IEnumerator GameOver()
    {
        Destroy(player.gameObject);
        deadFX.transform.position = player.transform.position;
        deadFX.Play();
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0;

        losePanel.SetActive(true);
        finalScoreText.text = $"score :{score.ToString()}";
        finalHighScoreText.text = $"highscore :{highscore.ToString()}";
    }
    public void Restart()
    {
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GamePlay");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
