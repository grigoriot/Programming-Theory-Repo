using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
            scoreText = FindObjectOfType<Text>();

        scoreText.text = "Points : " + score;
    }

    public void ChangeScore(int points)
    {
        score += points;
        scoreText.text = "Points : " + score;
    }
}
