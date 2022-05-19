using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float gameDurationInSeconds = 200;
    private float timeRemainig;
    public bool timerIsRunning = false;

    private void Start()
    {
        timeRemainig = gameDurationInSeconds;
        // Starts the timer auto
        timerIsRunning = true;
    }

    void Update()
    {

        if (timerIsRunning)
        {

            if (timeRemainig > 1)
            {
                timeRemainig -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemainig = 0;
                timerIsRunning = false;


            }


        }



    }




    public string GetTimeForDisplay()
    {
        float minutes = Mathf.FloorToInt(timeRemainig / 60);
        float seconds = Mathf.FloorToInt(timeRemainig % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }





















}
