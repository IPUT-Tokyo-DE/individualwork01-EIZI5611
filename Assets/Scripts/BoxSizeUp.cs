using UnityEngine;

public class ScaleByScore : MonoBehaviour
{
    private int lastCheckedScore = 0;
    private Vector3 originalScale;
    private Vector3 originalPosition;

    void Start()
    {
        // ���̃X�P�[���ƈʒu��ۑ�
        originalScale = transform.localScale;
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        int currentScore = TouchLine.Score;

        // 100�X�R�A���ƂɃT�C�Y�A�b�v
        int lastMilestone = lastCheckedScore / 120;
        int currentMilestone = currentScore / 120;

        if (currentMilestone > lastMilestone)
        {
            // �����񐔕������X�P�[���A�b�v
            int growthTimes = currentMilestone - lastMilestone;

            for (int i = 0; i < growthTimes; i++)
            {
                transform.localScale *= 1.1f; // 10%�傫������
            }

            lastCheckedScore = currentScore;

            // �ʒu�͂��̂܂܂ŃX�P�[�������ς���
            transform.localPosition = originalPosition;
        }
    }
}
