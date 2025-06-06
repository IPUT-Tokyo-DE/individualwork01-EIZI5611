using UnityEngine;

public class MoveDownByScore : MonoBehaviour
{
    private int lastScore = 0;

    [Header("設定項目")]
    public float moveAmountPerScore = 0.0000001f; // ★ 小さめに初期設定（0.01など）

    void Update()
    {
        int currentScore = TouchLine.Score;

        if (currentScore > lastScore)
        {
            int scoreDifference = currentScore - lastScore;

            // 移動量を減らして、ゆっくり下がる
            Vector3 pos = transform.position;
            pos.y -= moveAmountPerScore * scoreDifference;
            transform.position = pos;

            lastScore = currentScore;
        }
    }
}