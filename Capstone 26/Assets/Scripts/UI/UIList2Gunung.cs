using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIList2Gunung : MonoBehaviour
{
    int score, botol, kayu, detergen, kotoran, ranting = 0;

    public Text scoreTxt;
    [Header("List Gunung")]
    public Text score1BotolTxt;
    public Text score2KayuTxt;
    public Text score3KemDetergenTxt;
    public Text score4KotoranTxt;
    public Text score5RantingTxt; 

    [Header("Result Gunung")]
    public Text gunungTotal1BotolTxt;
    public Text gunungTotal2KayuTxt;
    public Text gunungTotal3DetergenTxt;
    public Text gunungTotal4KotoranTxt;
    public Text gunungTotal5RantingTxt;

    [Header("Finish lv Button")]
    public GameObject finishLv;

    private void Start()
    {
        score1BotolTxt.text = botol.ToString();
        score2KayuTxt.text = kayu.ToString();
        score3KemDetergenTxt.text = detergen.ToString();
        score4KotoranTxt.text = kotoran.ToString();
        score5RantingTxt.text = ranting.ToString();
    }
    
    // Function Gunung
    public void ScoreResultGunung()
    {
        scoreTxt.text = score.ToString();
        gunungTotal1BotolTxt.text = botol.ToString();
        gunungTotal2KayuTxt.text = kayu.ToString();
        gunungTotal3DetergenTxt.text = detergen.ToString();
        gunungTotal4KotoranTxt.text = kotoran.ToString();
        gunungTotal5RantingTxt.text = ranting.ToString();
    }
    public void AddSampahGunung1Botol()
    {
        score++;
        botol++;
        GameData.score++;
        GameData.score1Botol++;
        score1BotolTxt.text = botol.ToString();
        EnableWin();
    }
    public void AddSampahGunung2Kayu()
    {
        score++;
        kayu++;
        GameData.score++;
        GameData.score2Kayu++;
        score2KayuTxt.text = kayu.ToString();
        EnableWin();
    }
    public void AddSampahGunung3Detergen()
    {
        score++;
        detergen++;
        GameData.score++;
        GameData.score3KemDetergen++;
        score3KemDetergenTxt.text = detergen.ToString();
        EnableWin();
    }
    public void AddSampahGunung4Kotoran()
    {
        score++;
        kotoran++;
        GameData.score++;
        GameData.score4Kotoran++;
        score4KotoranTxt.text = kotoran.ToString();
        EnableWin();
    }
    public void AddSampahGunung5Ranting()
    {
        score++;
        ranting++;
        GameData.score++;
        GameData.score5Ranting++;
        score5RantingTxt.text = ranting.ToString();
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
