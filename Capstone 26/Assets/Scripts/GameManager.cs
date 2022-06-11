using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject PlayerPrefab;
    Scene scene;
    string sceneName;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
        if (sceneName == "2a. Gameplay Taman" || sceneName == "2b. Gameplay Gunung" || sceneName == "2c. Gameplay Pantai")
        {
            PlayerPrefab = GameData.instance.playerChar;
            spawnChar();
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

    public void StartLevelaTaman()
    {
        ResumeGame();
        SceneManager.LoadScene("2a. Gameplay Taman");
    }
    public void StartLevelbGunung()
    {
        ResumeGame();
        SceneManager.LoadScene("2b. Gameplay Gunung");
    }
    public void StartLevelcPantai()
    {
        ResumeGame();
        SceneManager.LoadScene("2c. Gameplay Pantai");
    }
    public void Daur()
    {
        ResumeGame();
        SceneManager.LoadScene("3. Daur sampah");
    }

    public void ResetGame()
    {
        GameData.instance.ResetScore();
    }

    public void setChar(GameObject setChar)
    {
        GameData.instance.playerChar = setChar;
    }

    public void spawnChar()
    {
        Instantiate(PlayerPrefab);
    }
}
