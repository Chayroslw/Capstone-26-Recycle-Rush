using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIListFinalScore : MonoBehaviour
{
    public Text scoreTxt;

    public Text tamanTotal1BungaTxt;
    public Text tamanTotal2KotakTxt;
    public Text tamanTotal3LaukTxt;
    public Text tamanTotal4PlastikTxt;

    public Text gunungTotal1BotolTxt;
    public Text gunungTotal2KayuTxt;
    public Text gunungTotal3DetergenTxt;
    public Text gunungTotal4KotoranTxt;
    public Text gunungTotal5RantingTxt;

    public Text pantaiTotal1GelasTxt;
    public Text pantaiTotal2KantongTxt;
    public Text pantaiTotal3PenyaringTxt;
    public Text pantaiTotal4SedotanTxt;
    public Text pantaiTotal5BuahTxt;
    public Text pantaiTotal6SterofoamTxt;

    public void ShowFinalScore()
    {
        PlayWinSfx();

        scoreTxt.text = GameData.score.ToString();
        tamanTotal1BungaTxt.text = GameData.score1Bunga.ToString();
        tamanTotal2KotakTxt.text = GameData.score2Kotak.ToString();
        tamanTotal3LaukTxt.text = GameData.score3Lauk.ToString();
        tamanTotal4PlastikTxt.text = GameData.score4Plastik.ToString();

        gunungTotal1BotolTxt.text = GameData.score1Botol.ToString();
        gunungTotal2KayuTxt.text = GameData.score2Kayu.ToString();
        gunungTotal3DetergenTxt.text = GameData.score3KemDetergen.ToString();
        gunungTotal4KotoranTxt.text = GameData.score4Kotoran.ToString();
        gunungTotal5RantingTxt.text = GameData.score5Ranting.ToString();

        pantaiTotal1GelasTxt.text = GameData.score1Gelas.ToString();
        pantaiTotal2KantongTxt.text = GameData.score2Kantong.ToString();
        pantaiTotal3PenyaringTxt.text = GameData.score3Penyaring.ToString();
        pantaiTotal4SedotanTxt.text = GameData.score4Sedotan.ToString();
        pantaiTotal5BuahTxt.text = GameData.score5Buah.ToString();
        pantaiTotal6SterofoamTxt.text = GameData.score6Sterofoam.ToString();
    }

    public void PlayWinSfx()
    {
        SoundManager.Instance.WinSfx();
    }
}
