using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public float distanceToCollect = 4.0f;
    public string itemTag = "PickableItem";
    public KeyCode collectKey = KeyCode.E;

    void Update()
    {
        if (Input.GetKeyDown(collectKey))
        {
            CollectItems();
        }
    }

    void CollectItems()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag(itemTag);
        foreach (GameObject item in items)
        {
            if (Vector3.Distance(transform.position, item.transform.position) <= distanceToCollect)
            {
                Destroy(item);
                Counter.instance.counter++;
                Debug.Log(Counter.instance.counter);
            }
        }
    }
}