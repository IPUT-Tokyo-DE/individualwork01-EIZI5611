using UnityEngine;
using TMPro; // TextMeshPro�g���Ȃ炱����

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + TouchLine.Score.ToString();
    }
}