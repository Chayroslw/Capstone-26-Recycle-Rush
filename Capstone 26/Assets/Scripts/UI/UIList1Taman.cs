using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIList1Taman : MonoBehaviour
{
    int score, bunga, kotak, lauk, plastik;

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
        score1BungaTxt.text = bunga.ToString();
        score2KotakTxt.text = kotak.ToString();
        score3LaukTxt.text = lauk.ToString();
        score4PlastikTxt.text = plastik.ToString();
    }

    // Function Taman
    public void ScoreResultTaman()
    {
        scoreTxt.text = score.ToString();
        tamanTotal1BungaTxt.text = bunga.ToString();
        tamanTotal2KotakTxt.text = kotak.ToString();
        tamanTotal3LaukTxt.text = lauk.ToString();
        tamanTotal4PlastikTxt.text = plastik.ToString();
    }
    public void AddSampahTaman1Bunga()
    {
        score++;
        bunga++;
        GameData.score++;
        GameData.score1Bunga++;
        score1BungaTxt.text = bunga.ToString();
        EnableWin();
    }
    public void AddSampahTaman2Kotak()
    {
        score++;
        kotak++;
        GameData.score++;
        GameData.score2Kotak++;
        score2KotakTxt.text = kotak.ToString();
        EnableWin();
    }
    public void AddSampahTaman3Lauk()
    {
        score++;
        lauk++;
        GameData.score++;
        GameData.score3Lauk++;
        score3LaukTxt.text = lauk.ToString();
        EnableWin();
    }
    public void AddSampahTaman4Plastik()
    {
        score++;
        plastik++;
        GameData.score++;
        GameData.score4Plastik++;
        score4PlastikTxt.text = plastik.ToString();
        EnableWin();
    }
    public void EnableWin()
    {
        if (!finishLv.activeInHierarchy)
        {
            finishLv.SetActive(true);
            TimeCounter.win = true;
        }
        else
        {
            return;
        }
    }
}
