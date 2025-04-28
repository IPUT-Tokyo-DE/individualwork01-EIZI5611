using UnityEngine;

public class MoveDownByScore : MonoBehaviour
{
    private int lastScore = 0;

    [Header("�ݒ荀��")]
    public float moveAmountPerScore = 0.0000001f; // �� �����߂ɏ����ݒ�i0.01�Ȃǁj

    void Update()
    {
        int currentScore = TouchLine.Score;

        if (currentScore > lastScore)
        {
            int scoreDifference = currentScore - lastScore;

            // �ړ��ʂ����炵�āA������艺����
            Vector3 pos = transform.position;
            pos.y -= moveAmountPerScore * scoreDifference;
            transform.position = pos;

            lastScore = currentScore;
        }
    }
}