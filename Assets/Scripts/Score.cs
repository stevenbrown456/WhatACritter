﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    //public variales in unity
    public TextMesh displayText;

    //Private variables can't be touched by other scripts 

    private int currentValue = 0;

    //update both the data value and the visual display

    public void ChangeValue(int _toChange)


    {

        currentValue = currentValue + _toChange;
        displayText.text = currentValue.ToString();

    }
    //reset the score to zero

    public void ResetScore()

    {
        currentValue = 0;
        displayText.text = currentValue.ToString();

    }
	
	
	
	
}
