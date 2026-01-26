using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score = 10;

    void Start()
    {
        InvokeRepeating(nameof(addScore),1f,2f);
        updateScore(); // To show score at time = 0s
    }

    void addScore()
    {
        score+=10;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "Score : " +score;
    }
}
