using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePointThing : MonoBehaviour
{
    [SerializeField] private string targetTag = "PointThing"; // Á‚·‘ÎÛ‚Ìƒ^ƒO‚ğw’è

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Destroy(other.gameObject);
        }
    }
}