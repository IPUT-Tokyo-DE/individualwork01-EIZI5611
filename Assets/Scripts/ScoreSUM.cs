using UnityEngine;
using TMPro; // TextMeshPro使うならこっち

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + TouchLine.Score.ToString();
    }
}