using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public static LifeCounter lifeCounterInstance;

    public int lifeCounter = 3;

    private void Awake()
    {
        if (lifeCounterInstance == null)
        {
            lifeCounterInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}