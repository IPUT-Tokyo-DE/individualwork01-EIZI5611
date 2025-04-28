using UnityEngine;
using TMPro; // TextMeshProŽg‚¤‚È‚ç‚±‚Á‚¿

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + TouchLine.Score.ToString();
    }
}