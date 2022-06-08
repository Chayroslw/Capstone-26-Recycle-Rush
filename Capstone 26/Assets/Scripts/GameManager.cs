using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Values")]
    public int score;
    public int scoreSampah1;
    public int scoreSampah2;
    public int scoreSampah3;
    public int scoreSampah4;

    [Header("InGame UI")]
    public GameObject finishLv;
    public Image sampah1;
    public Image sampah2;
    public Image sampah3;
    public Image sampah4;
    public Text scoreSampah1Txt;
    public Text scoreSampah2Txt;
    public Text scoreSampah3Txt;
    public Text scoreSampah4Txt;
    public Text scoreTxt;
    public Text totalSampah1Txt;
    public Text totalSampah2Txt;
    public Text totalSampah3Txt;
    public Text totalSampah4Txt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (score > 0)
        {
            finishLv.SetActive(true);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void BackToMenu()
    {
        ResumeGame();
        SceneManager.LoadScene("1. Main Menu");
    }

    public void StartGame()
    {
        ResumeGame();
        SceneManager.LoadScene("2. Gameplay");
    }

    public void Daur()
    {
        ResumeGame();
        SceneManager.LoadScene("3. Daur sampah");
    }

    public void ResetScore()
    {
        score = 0;
        scoreSampah1 = 0;
        scoreSampah2 = 0;
        scoreSampah3 = 0;
        scoreSampah4 = 0;
    }

    public void ScoreResult()
    {
        PauseGame();
        scoreTxt.text = score.ToString();
        totalSampah1Txt.text = scoreSampah1.ToString();
        totalSampah2Txt.text = scoreSampah1.ToString();
        totalSampah3Txt.text = scoreSampah1.ToString();
        totalSampah4Txt.text = scoreSampah1.ToString();
    }

    public void AddSampah1()
    {
        score++;
        scoreSampah1++;
        scoreSampah1Txt.text = scoreSampah1.ToString();
    }

    public void AddSampah2()
    {
        score++;
        scoreSampah2++;
        scoreSampah2Txt.text = scoreSampah2.ToString();
    }

    public void AddSampah3()
    {
        score++;
        scoreSampah3++;
        scoreSampah3Txt.text = scoreSampah3.ToString();
    }

    public void AddSampah4()
    {
        score++;
        scoreSampah4++;
        scoreSampah4Txt.text = scoreSampah4.ToString();
    }
}
