using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData instance;

    [Header("Main Value")]
    public static int score;

    [Header("Value Taman")]
    // Taman
    public static int score1Bunga;
    public static int score2Kotak;
    public static int score3Lauk;
    public static int score4Plastik;
    [Header("Value Gunung")]
    // Gunung
    public static int score1Botol;
    public static int score2Kayu;
    public static int score3KemDetergen;
    public static int score4Kotoran;
    public static int score5Ranting;
    [Header("Value Pantai")]
    // pantai
    public static int score1Gelas;
    public static int score2Kantong;
    public static int score3Penyaring;
    public static int score4Sedotan;
    public static int score5Buah;
    public static int score6Sterofoam;

    public GameObject playerChar;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != null && instance != this)
        {
            Destroy(this);
        }
    }

    public void ResetScore()
    {
        score = 0;
        // Taman
        score1Bunga = 0;
        score2Kotak = 0;
        score3Lauk = 0;
        score4Plastik = 0;
        // Gunung
        score1Botol = 0;
        score2Kayu = 0;
        score3KemDetergen = 0;
        score4Kotoran = 0;
        score5Ranting = 0;
        // Pantai
        score1Gelas = 0;
        score2Kantong = 0;
        score3Penyaring = 0;
        score4Sedotan = 0;
        score5Buah = 0;
        score6Sterofoam = 0;
    }
}