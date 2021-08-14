using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public InputField inputField;
    public Text BestScore;

    public void Update()
    {
        if (GameManager.Instance.HighScore == 0)
        {
            BestScore.text = "Best Score : Blank : 0";    
        }
        else
        {
            BestScore.text = $"Best Score : {GameManager.Instance.HighName} : {GameManager.Instance.HighScore}";
        }
    }
    public void StartGame()
    {
        GameManager.Instance.Name = inputField.text;
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
        GameManager.Instance.SaveGame();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void EnterName()
    {
        GameManager.Instance.Name = inputField.text;
    }

    public void ResetScore()
    {
        GameManager.Instance.HighName = "Blank";
        GameManager.Instance.HighScore = 0;
    }
}
