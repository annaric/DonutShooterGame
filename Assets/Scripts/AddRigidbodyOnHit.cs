using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbodyOnHit : MonoBehaviour
{
    public string targetTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            AddRigidbodyRecursive(collision.gameObject.transform);

        }
    }

    void AddRigidbodyRecursive(Transform parent)
    {
        parent.gameObject.AddComponent<Rigidbody>();
        if (parent.gameObject.GetComponent<Animator>() != null)
        {
            parent.gameObject.GetComponent<Animator>().enabled = false;
        }

        for (int i = 0; i < parent.childCount; i++)
        {
            AddRigidbodyRecursive(parent.GetChild(i));
        }
    }
}