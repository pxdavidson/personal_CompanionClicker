﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerManager : MonoBehaviour
{
    // Variables
    int clickValue = 5;

    // Cache

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Passes the current clicker value to the score manager
    public void ButtonClicked()
    {
        FindObjectOfType<ScoreManager>().SetScore(clickValue);
    }
}
