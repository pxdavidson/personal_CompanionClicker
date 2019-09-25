using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Variables
    int score =0;
    int companionMod = 2;

    // Cache
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Changes the score with a value passed in
    public void ChangeScore(int value)
    {
        score += (value * companionMod);
        FindObjectOfType<ScoreDisplay>().UpdateScore(score);
    }
}
