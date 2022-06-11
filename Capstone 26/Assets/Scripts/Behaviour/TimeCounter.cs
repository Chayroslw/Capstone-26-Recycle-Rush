using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class TimeCounter : MonoBehaviour
{
    public static GameObject instance;
    [Header("Main Settings")]
    public Text TextTimer;
    public float TimerValue;

    public bool isSpawnPowerUp;

    public GameObject[] powerUp;


    [Header("Condition")]
    public UnityEvent TimerFinishEvent;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerValue > 0)
        {
            TimerValue -= Time.deltaTime;
        }
        else
        {
            TimerValue = 0;
            TimerFinishEvent.Invoke();
        }
        DisplayTime(TimerValue);


    }

    public void Freeze()
    {
        StartCoroutine("delay");
    }

    IEnumerator delay()
    {
        Time.timeScale = 0.1f;
        yield return new WaitForSecondsRealtime(5);
        Time.timeScale = 1f;
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
