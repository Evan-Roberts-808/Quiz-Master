using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToComplete = 15f;
    [SerializeField] float timeBeforeNextQuestion = 5f;
    
    public bool loadNextQuestion;
    public float fillFraction;
    public bool isAnswering = false;
    float timerValue;

    // Update is called once per frame
    private void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer() {
        timerValue = 0;
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnswering)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToComplete;
            }
            else
            {
                timerValue = timeBeforeNextQuestion;
                isAnswering = false;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeBeforeNextQuestion;
            }
            else
            {
                timerValue = timeToComplete;
                isAnswering = true;
                loadNextQuestion = true;
            }
        }

        Debug.Log(timerValue);
    }
}
