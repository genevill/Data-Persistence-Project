using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    public Text HighScoreText;
    
    public void Update()
    {
        HighScore();
    }

    public void HighScore()
    {
        HighScoreText.text = $"Best Score : {GameManager.Instance.HighName} : {GameManager.Instance.HighScore}";
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
