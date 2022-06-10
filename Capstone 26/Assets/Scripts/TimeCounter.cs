using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class TimeCounter : MonoBehaviour
{
    [Header("Main Settings")]
    public float TimerValue;
    public Text TextTimer;

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
    }
}
