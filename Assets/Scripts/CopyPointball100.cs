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
        while (true) // Å© ÉãÅ[ÉvÇ≈åJÇËï‘Çµë±ÇØÇÈ
        {
            Instantiate(Pointball100, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}