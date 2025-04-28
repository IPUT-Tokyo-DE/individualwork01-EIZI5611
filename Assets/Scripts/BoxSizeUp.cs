using UnityEngine;

public class ScaleByScore : MonoBehaviour
{
    private int lastCheckedScore = 0;
    private Vector3 originalScale;
    private Vector3 originalPosition;

    void Start()
    {
        // 元のスケールと位置を保存
        originalScale = transform.localScale;
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        int currentScore = TouchLine.Score;

        // 100スコアごとにサイズアップ
        int lastMilestone = lastCheckedScore / 120;
        int currentMilestone = currentScore / 120;

        if (currentMilestone > lastMilestone)
        {
            // 成長回数分だけスケールアップ
            int growthTimes = currentMilestone - lastMilestone;

            for (int i = 0; i < growthTimes; i++)
            {
                transform.localScale *= 1.1f; // 10%大きくする
            }

            lastCheckedScore = currentScore;

            // 位置はそのままでスケールだけ変える
            transform.localPosition = originalPosition;
        }
    }
}
