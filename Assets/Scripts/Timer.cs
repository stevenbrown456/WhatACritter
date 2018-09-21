using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    //display visual timer
    public TextMesh displayText;

    //starting time for the timer
    public float timerDuration; 

    //current seconds remaining on the timer 
    private float timeRemaining = 0; 




	// Use this for initialization
	void Start () {
        StartTimer();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsTimerRunning())
        {
            //timer is running, so process

            //updated time reamining
            timeRemaining = timeRemaining - Time.deltaTime;

            //check if we've run out of time 
            if(timeRemaining<= 0)

            {
                StopTimer(); 

            }
            //update visual display 


            displayText.text = Mathf.CeilToInt(timeRemaining).ToString();



        }
	}

    //starts timer
    public void StartTimer()

    {
        timeRemaining = timerDuration;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();

    }
    //stop the timer coutning
    public void StopTimer()

    {
        timeRemaining = 0;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();

    }


//Is the timer currently running 
public bool IsTimerRunning()
    {
        if (timeRemaining !=0)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

}
