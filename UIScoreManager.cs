using UnityEngine;
using UnityEngine.UI;

public class UIScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
