using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerStuff : MonoBehaviour
{
    public Text timeText;

    public static float Timer;

    public bool timerIsRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            Timer += Time.deltaTime;
            DisplayTime(Timer);
        }

    }


        void DisplayTime(float timeToDisplay)
    {
    timeToDisplay += 1;
    float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
}
