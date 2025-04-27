using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using AudioSource dingSFX;

public class LogicScript : MonoBehaviour
{
    public AudioSource startSFX;
    public AudioSource dieSFX;
    public AudioSource gameOverSFX;

    public int playerScore;
    //public int gameOverScore;
    public Text scoreText;
    //public Text gameOverScoreText;
    public GameObject gameOverScreen;

    void Start()
    {
        // Play the start sound when the game begins
        startSFX.Play();

        //gameOverScore = PlayerPrefs.GetInt("HighestScore", 0);
        //UpdateHighestScoreText();
    }
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();

        //if (playerScore > gameOverScore)
        //{
        //    playerScore = gameOverScore;
        //    PlayerPrefs.SetInt("HighestScore", gameOverScore); // Save the new highest score
        //    UpdateHighestScoreText();
        //}
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverSFX.Play();

        gameOverScreen.SetActive(true);
    }

    //private void UpdateHighestScoreText()
    //{
    //    gameOverScoreText.text = "" + gameOverScore.ToString();
    //}


    public void PlayDieSound()
    {
        dieSFX.Play();
    }
}

