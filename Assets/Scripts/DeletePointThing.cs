using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePointThing : MonoBehaviour
{
    [SerializeField] private string targetTag = "PointThing"; // 消す対象のタグを指定

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Destroy(other.gameObject);
        }
    }
}