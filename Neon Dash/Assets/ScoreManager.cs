using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; 

    int score = 0;

    void Start()
    {
        InvokeRepeating("AddScore", 1f, 1f);
    }

    void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}