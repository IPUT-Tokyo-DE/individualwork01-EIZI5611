using UnityEngine;

public class HitBoxScaleByScore : MonoBehaviour
{
    private int LastCheckedScore = 0;
    private Vector3 OriginalScale;

    void Start()
    {
        // ���̃X�P�[����ۑ�
        OriginalScale = transform.localScale;
    }

    void Update()
    {
        int currentScore = TouchLine.Score;

        // 100�X�R�A���ƂɃT�C�Y�A�b�v
        int lastMilestone = LastCheckedScore / 100;
        int currentMilestone = currentScore / 100;

        if (currentMilestone > lastMilestone)
        {
            // �����񐔕������X�P�[���A�b�v
            int growthTimes = currentMilestone - lastMilestone;

            for (int i = 0; i < growthTimes; i++)
            {
                transform.localScale *= 1.2f; // 10%�傫������
            }

            LastCheckedScore = currentScore;
        }
    }
}
