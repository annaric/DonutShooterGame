using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILifeCounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI lifeCounterText;
    public TMPro.TextMeshProUGUI youDiedText;

    void Update()
    {
        lifeCounterText.text = LifeCounter.lifeCounterInstance.lifeCounter.ToString();
        if(LifeCounter.lifeCounterInstance.lifeCounter == 0)
        {
            youDiedText.text = "Oh no! You died...";
        }
    }
}
