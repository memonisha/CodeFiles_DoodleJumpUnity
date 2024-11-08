using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public Text highScoreText;

    private int score = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void IncreaseScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "High Score: " + score;
        }
    }
}
