using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenNotUsed : MonoBehaviour
{
    public float lifeTime = 1.0f;

    void Start()
    {
        StartCoroutine(WaitThenDie());
    }


    IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
