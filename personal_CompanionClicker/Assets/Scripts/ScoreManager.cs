using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Variables
    int score =0;
    
    // Cache
    ScoreDisplay scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Changes the score with a value passed in
    public void SetScore(int value)
    {
        score += (value);
        scoreDisplay.UpdateScore(score);
    }

    // Returns the current score
    public int GetScore()
    {
        return score;
    }
}
