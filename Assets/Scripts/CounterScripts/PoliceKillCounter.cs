using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceKillCounter : MonoBehaviour
{
    // Static instance of the class
    public static PoliceKillCounter policeKillCounterInstance;

    public int policeKillCounter = 0;

    private void Awake()
    {
        if (policeKillCounterInstance == null)
        {
            policeKillCounterInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}