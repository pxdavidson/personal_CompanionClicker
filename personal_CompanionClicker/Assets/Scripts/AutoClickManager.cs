using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickManager : MonoBehaviour
{
    // Variables
    float rawTimeElapsed = 0f;
    int timeElapsed = 0;
    int companionMod = 1;
    int lovePerSecond = 1;

    // Cache
    ScoreManager scoreManager; 
    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTimeElapsed();
    }

    // Counts time as it elapses and stores it in timeElapsed
    private void CalculateTimeElapsed()
    {
        int time = timeElapsed;
        rawTimeElapsed += Time.deltaTime;
        timeElapsed = Mathf.RoundToInt(rawTimeElapsed);
        if (time < timeElapsed)
        {
            CalculateLovePerSecond();
        }
    }

    // Calculates the current love per second
    private void CalculateLovePerSecond()
    {
        int loveThisSecond = lovePerSecond * companionMod;
        Debug.Log(companionMod);
        UpdateScoreManager(loveThisSecond);
    }

    // Updates the ScoreManager
    public void UpdateScoreManager(int lps)
    {
        scoreManager.SetScore(lps);
    }

    // Changes the companion mod passed on the value passed in
    public void ChangeCompanionModifier(int newValue)
    {
        companionMod += newValue;
    }
}
