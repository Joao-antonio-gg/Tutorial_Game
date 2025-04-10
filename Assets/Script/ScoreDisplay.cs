using UnityEngine;
using TMPro; // necessário para TextMeshPro

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Pontos", 0);
        scoreText.text = "Score: " + score.ToString();
    }
}
