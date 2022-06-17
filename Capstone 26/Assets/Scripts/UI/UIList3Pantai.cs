using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIList3Pantai : MonoBehaviour
{
    int score, gelas, kantong, penyaring, sedotan, buah, sterofoam = 0;

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
        score1GelasTxt.text = gelas.ToString();
        score2KantongTxt.text = kantong.ToString();
        score3PenyaringTxt.text = penyaring.ToString();
        score4SedotanTxt.text = sedotan.ToString();
        score5BuahTxt.text = buah.ToString();
        score6SterofoamTxt.text = sterofoam.ToString();
    }

    // Function Pantai
    public void ScoreResultPantai()
    {
        scoreTxt.text = score.ToString();
        pantaiTotal1GelasTxt.text = gelas.ToString();
        pantaiTotal2KantongTxt.text = kantong.ToString();
        pantaiTotal3PenyaringTxt.text = penyaring.ToString();
        pantaiTotal4SedotanTxt.text = sedotan.ToString();
        pantaiTotal5BuahTxt.text = buah.ToString();
        pantaiTotal6SterofoamTxt.text = sterofoam.ToString();
    }
    public void AddSampahPantai1Gelas()
    {
        score++;
        gelas++;
        GameData.score++;
        GameData.score1Gelas++;
        score1GelasTxt.text = gelas.ToString();
        EnableWin();
    }
    public void AddSampahPantai2Kantong()
    {
        score++;
        kantong++;
        GameData.score++;
        GameData.score2Kantong++;
        score2KantongTxt.text = kantong.ToString();
        EnableWin();
    }
    public void AddSampahPantai3Penyaring()
    {
        score++;
        penyaring++;
        GameData.score++;
        GameData.score3Penyaring++;
        score3PenyaringTxt.text = penyaring.ToString();
        EnableWin();
    }
    public void AddSampahPantai4Sedotan()
    {
        score++;
        sedotan++;
        GameData.score++;
        GameData.score4Sedotan++;
        score4SedotanTxt.text = sedotan.ToString();
        EnableWin();
    }
    public void AddSampahPantai5Buah()
    {
        score++;
        buah++;
        GameData.score++;
        GameData.score5Buah++;
        score5BuahTxt.text = buah.ToString();
        EnableWin();
    }
    public void AddSampahPantai6Sterofoam()
    {
        score++;
        sterofoam++;
        GameData.score++;
        GameData.score6Sterofoam++;
        score6SterofoamTxt.text = sterofoam.ToString();
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
