using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class TimeCounter : MonoBehaviour
{
    public static GameManager instance;
    [Header("Main Settings")]
    public Text TextTimer;
    public float TimerValue;
    int score;

    public bool isSpawnPowerUp;
    public bool FreezeTimer = false;

    public GameObject[] powerUp;

    [SerializeField] private AudioClip _win;
    [SerializeField] private AudioClip _lose;

    bool played = false;

    [Header("Condition")]
    public UnityEvent TimerFinishEvent;
    public UnityEvent TimerFinishWinEvent;

    void Update()
    {
        score = GameData.score;
        if (TimerValue > 0 && !FreezeTimer)
        {
            TimerValue -= Time.deltaTime;
        } 
        else if (TimerValue > 0 && FreezeTimer)
        {
            return;
        }
        else if (TimerValue < 0 && score > 0)
        {
            if (!played)
            {
                SoundManager.Instance.PlaySound(_win);
                played = true;
            }
            else
                return;
            SoundManager.Instance.StopBgm();
            TimerFinishWinEvent.Invoke();
        }
        else if (TimerValue < 0 && score < 1)
        {
            if (!played)
            {
                SoundManager.Instance.PlaySound(_lose);
                played = true;
            }
            else
                return;
            SoundManager.Instance.StopBgm();
            TimerFinishEvent.Invoke();
        }
        DisplayTime(TimerValue);
        if (Input.GetKeyDown(KeyCode.L))
        {
            TimerValue = 1;
        }
    }

    public void Freeze()
    {
        StartCoroutine("delay");
    }

    IEnumerator delay()
    {
        FreezeTimer = true;
        yield return new WaitForSecondsRealtime(3);
        FreezeTimer = false;
    }

    public void AddTime()
    {
        TimerValue += 5;

    }

    public IEnumerator SpawnPowerUp()
    {
        isSpawnPowerUp = true;
        Debug.Log("Power Up");
        int rand = Random.Range(0, powerUp.Length);
        Instantiate(powerUp[rand], new Vector3(Random.Range(-5f, 5f), -4, 0), Quaternion.identity);
        yield return new WaitForSeconds(1);
        isSpawnPowerUp = false;
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if (timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        TextTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (seconds % 20 == 0 && !isSpawnPowerUp)
        {
            StartCoroutine("SpawnPowerUp");
        }

    }
}
