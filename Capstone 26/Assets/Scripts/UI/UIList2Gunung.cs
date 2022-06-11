using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIList2Gunung : MonoBehaviour
{
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
        score1BotolTxt.text = GameData.score1Botol.ToString();
        score2KayuTxt.text = GameData.score2Kayu.ToString();
        score3KemDetergenTxt.text = GameData.score3KemDetergen.ToString();
        score4KotoranTxt.text = GameData.score4Kotoran.ToString();
        score5RantingTxt.text = GameData.score5Ranting.ToString();
    }
    
    // Function Gunung
    public void ScoreResultGunung()
    {
        GameManager.instance.PauseGame();
        scoreTxt.text = GameData.score.ToString();
        score1BotolTxt.text = GameData.score1Botol.ToString();
        score2KayuTxt.text = GameData.score2Kayu.ToString();
        score3KemDetergenTxt.text = GameData.score3KemDetergen.ToString();
        score4KotoranTxt.text = GameData.score4Kotoran.ToString();
        score5RantingTxt.text = GameData.score5Ranting.ToString();
    }
    public void AddSampahGunung1Botol()
    {
        GameData.score++;
        GameData.score1Botol++;
        score1BotolTxt.text = GameData.score1Botol.ToString();
        EnableWin();
    }
    public void AddSampahGunung2Kayu()
    {
        GameData.score++;
        GameData.score2Kayu++;
        score2KayuTxt.text = GameData.score2Kayu.ToString();
        EnableWin();
    }
    public void AddSampahGunung3Detergen()
    {
        GameData.score++;
        GameData.score3KemDetergen++;
        score3KemDetergenTxt.text = GameData.score3KemDetergen.ToString();
        EnableWin();
    }
    public void AddSampahGunung4Kotoran()
    {
        GameData.score++;
        GameData.score4Kotoran++;
        score4KotoranTxt.text = GameData.score4Kotoran.ToString();
        EnableWin();
    }
    public void AddSampahGunung5Ranting()
    {
        GameData.score++;
        GameData.score5Ranting++;
        score5RantingTxt.text = GameData.score5Ranting.ToString();
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
