using UnityEngine;

public class MoveDownByScore : MonoBehaviour
{
    private int lastScore = 0;

    [Header("İ’è€–Ú")]
    public float moveAmountPerScore = 0.0000001f; // š ¬‚³‚ß‚É‰Šúİ’èi0.01‚È‚Çj

    void Update()
    {
        int currentScore = TouchLine.Score;

        if (currentScore > lastScore)
        {
            int scoreDifference = currentScore - lastScore;

            // ˆÚ“®—Ê‚ğŒ¸‚ç‚µ‚ÄA‚ä‚Á‚­‚è‰º‚ª‚é
            Vector3 pos = transform.position;
            pos.y -= moveAmountPerScore * scoreDifference;
            transform.position = pos;

            lastScore = currentScore;
        }
    }
}