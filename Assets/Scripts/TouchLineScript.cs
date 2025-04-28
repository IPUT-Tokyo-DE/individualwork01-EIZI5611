using UnityEngine;

public class TouchLine : MonoBehaviour
{
    public static int Score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PointThing"))
        {
            switch (other.gameObject.name)
            {
                case "Pointball100(Clone)":
                    Score += 100;
                    break;
                case "Pointball1000":
                    Score += 1000;
                    break;
                case "Pointball10000":
                    Score += 10000;
                    break;
                default:
                    Score += 0; // ÇªÇÃëºÇÃñºëOÇÃèÍçá
                    break;
            }
        }
    }
}