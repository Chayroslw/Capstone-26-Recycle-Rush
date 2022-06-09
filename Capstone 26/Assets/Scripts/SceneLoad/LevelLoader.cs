using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    private Slider slider;
    public float FillSpeed = 0.5f;
    private float targetProgress = 0;
    public GameObject Preparing;
    public GameObject ClickToContinue;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    private void Start()
    {
        IncrementProgress(1f);

    }
    private void Update()
    {
        if(slider.value < targetProgress)
        {
            slider.value += FillSpeed * Time.deltaTime;

            if (slider.value == 1f)
            {
                Preparing.SetActive(false);
                ClickToContinue.SetActive(true);
            }
        }
    }

    private void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
