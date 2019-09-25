using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    // Variables


    // Cache
    Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update displayed score
     public void UpdateScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}
