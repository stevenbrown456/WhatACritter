﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public List<GameObject> critterPrefabs;
    public float critterSpwanFrequency = 1.0f;
    public Score scoreDisplay;
    public Timer timer;
    public SpriteRenderer button;

    private float lastCritterSpawn = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //check if its time to spawn the next critter 
        float nextSpawnTime = lastCritterSpawn + critterSpwanFrequency;
        if (Time.time >= nextSpawnTime && timer.IsTimerRunning()== true)

        {
            //it is time 

            //choose a random critter to spawn
            int critterIndex = Random.Range(0, critterPrefabs.Count);
            GameObject prefabToSpawn = critterPrefabs[critterIndex];

            //spawn the critter
            GameObject spawnedCritter = Instantiate(prefabToSpawn);

            //get access to our critter script

            Critter critterScript = spawnedCritter.GetComponent<Critter>();

            //tell the critte scrpit what the score object is and the timer object
            critterScript.scoreDisplay = scoreDisplay;
            critterScript.timer = timer;

            //update the most recent spawn to now
            lastCritterSpawn = Time.time;

        

        }
        //update button visibility
        if(timer.IsTimerRunning() == true)
        {
            button.enabled = false;

        }
        else
        {
            button.enabled = true; 

        }
	}

    private void OnMouseDown()
    {
        if (timer.IsTimerRunning() == false)
        {
            timer.StartTimer();
            scoreDisplay.ResetScore();

        }
    }
}
