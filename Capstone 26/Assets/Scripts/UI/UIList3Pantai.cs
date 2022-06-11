using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIList3Pantai : MonoBehaviour
{
    public Text scoreTxt;
    [Header("List Pantai")]
    public Text score1GelasTxt;
    public Text score2KantongTxt;
    public Text score3PenyaringTxt;
    public Text score4SedotanTxt;
    public Text score5BuahTxt;
    public Text score6SterofoamTxt;

    [Header("Result Pantai")]
    public Text pantaiTotal1GelasTxt;
    public Text pantaiTotal2KantongTxt;
    public Text pantaiTotal3PenyaringTxt;
    public Text pantaiTotal4SedotanTxt;
    public Text pantaiTotal5BuahTxt;
    public Text pantaiTotal6SterofoamTxt;

    [Header("Finish lv Button")]
    public GameObject finishLv;

    private void Start()
    {
        score1GelasTxt.text = GameData.score1Gelas.ToString();
        score2KantongTxt.text = GameData.score2Kantong.ToString();
        score3PenyaringTxt.text = GameData.score3Penyaring.ToString();
        score4SedotanTxt.text = GameData.score4Sedotan.ToString();
        score5BuahTxt.text = GameData.score5Buah.ToString();
        score6SterofoamTxt.text = GameData.score6Sterofoam.ToString();
    }

    // Function Pantai
    public void ScoreResultPantai()
    {
        GameManager.instance.PauseGame();
        scoreTxt.text = GameData.score.ToString();
        score1GelasTxt.text = GameData.score1Gelas.ToString();
        score2KantongTxt.text = GameData.score2Kantong.ToString();
        score3PenyaringTxt.text = GameData.score3Penyaring.ToString();
        score4SedotanTxt.text = GameData.score4Sedotan.ToString();
        score5BuahTxt.text = GameData.score5Buah.ToString();
        score6SterofoamTxt.text = GameData.score6Sterofoam.ToString();
    }
    public void AddSampahPantai1Gelas()
    {
        GameData.score++;
        GameData.score1Gelas++;
        score1GelasTxt.text = GameData.score1Gelas.ToString();
        EnableWin();
    }
    public void AddSampahPantai2Kantong()
    {
        GameData.score++;
        GameData.score2Kantong++;
        score2KantongTxt.text = GameData.score2Kantong.ToString();
        EnableWin();
    }
    public void AddSampahPantai3Penyaring()
    {
        GameData.score++;
        GameData.score3Penyaring++;
        score3PenyaringTxt.text = GameData.score3Penyaring.ToString();
        EnableWin();
    }
    public void AddSampahPantai4Sedotan()
    {
        GameData.score++;
        GameData.score4Sedotan++;
        score4SedotanTxt.text = GameData.score4Sedotan.ToString();
        EnableWin();
    }
    public void AddSampahPantai5Buah()
    {
        GameData.score++;
        GameData.score5Buah++;
        score5BuahTxt.text = GameData.score5Buah.ToString();
        EnableWin();
    }
    public void AddSampahPantai6Sterofoam()
    {
        GameData.score++;
        GameData.score6Sterofoam++;
        score6SterofoamTxt.text = GameData.score6Sterofoam.ToString();
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
