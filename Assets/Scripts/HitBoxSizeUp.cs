using UnityEngine;

public class HitBoxScaleByScore : MonoBehaviour
{
    private int LastCheckedScore = 0;
    private Vector3 OriginalScale;

    void Start()
    {
        // 元のスケールを保存
        OriginalScale = transform.localScale;
    }

    void Update()
    {
        int currentScore = TouchLine.Score;

        // 100スコアごとにサイズアップ
        int lastMilestone = LastCheckedScore / 100;
        int currentMilestone = currentScore / 100;

        if (currentMilestone > lastMilestone)
        {
            // 成長回数分だけスケールアップ
            int growthTimes = currentMilestone - lastMilestone;

            for (int i = 0; i < growthTimes; i++)
            {
                transform.localScale *= 1.2f; // 10%大きくする
            }

            LastCheckedScore = currentScore;
        }
    }
}
