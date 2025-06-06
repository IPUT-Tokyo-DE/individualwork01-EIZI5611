using System.Collections;
using UnityEngine;

public class CopyPointball100 : MonoBehaviour
{
    public GameObject Pointball100;
    public float spawnInterval = 1f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true) // ← ループで繰り返し続ける
        {
            Instantiate(Pointball100, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}