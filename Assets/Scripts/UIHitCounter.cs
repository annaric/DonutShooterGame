using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHitCounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI hitCounterText;

    void Update()
    {
        hitCounterText.text = PoliceKillCounter.policeKillCounterInstance.policeKillCounter.ToString();
    }
}
