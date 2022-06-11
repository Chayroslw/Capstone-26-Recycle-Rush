using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIList1Taman : MonoBehaviour
{
    public Text scoreTxt;
    [Header("List Taman")]
    public Text score1BungaTxt;
    public Text score2KotakTxt;
    public Text score3LaukTxt;
    public Text score4PlastikTxt;

    [Header("Result Taman")]
    public Text tamanTotal1BungaTxt;
    public Text tamanTotal2KotakTxt;
    public Text tamanTotal3LaukTxt;
    public Text tamanTotal4PlastikTxt;

    [Header("Finish lv Button")]
    public GameObject finishLv;

    private void Start()
    {
        score1BungaTxt.text = GameData.score1Bunga.ToString();
        score2KotakTxt.text = GameData.score2Kotak.ToString();
        score3LaukTxt.text = GameData.score3Lauk.ToString();
        score4PlastikTxt.text = GameData.score4Plastik.ToString();
    }

    // Function Taman
    public void ScoreResultTaman()
    {
        GameManager.instance.PauseGame();
        scoreTxt.text = GameData.score.ToString();
        score1BungaTxt.text = GameData.score1Bunga.ToString();
        score2KotakTxt.text = GameData.score2Kotak.ToString();
        score3LaukTxt.text = GameData.score3Lauk.ToString();
        score4PlastikTxt.text = GameData.score4Plastik.ToString();
    }
    public void AddSampahTaman1Bunga()
    {
        GameData.score++;
        GameData.score1Bunga++;
        score1BungaTxt.text = GameData.score1Bunga.ToString();
        EnableWin();
    }
    public void AddSampahTaman2Kotak()
    {
        GameData.score++;
        GameData.score2Kotak++;
        score2KotakTxt.text = GameData.score2Kotak.ToString();
        EnableWin();
    }
    public void AddSampahTaman3Lauk()
    {
        GameData.score++;
        GameData.score3Lauk++;
        score3LaukTxt.text = GameData.score3Lauk.ToString();
        EnableWin();
    }
    public void AddSampahTaman4Plastik()
    {
        GameData.score++;
        GameData.score4Plastik++;
        score4PlastikTxt.text = GameData.score4Plastik.ToString();
        EnableWin();
    }
    public void EnableWin()
    {
        if (!finishLv.activeInHierarchy)
        {
            finishLv.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
