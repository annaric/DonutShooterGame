using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI counterText;

    void Update()
    {
        counterText.text = Counter.instance.counter.ToString();
    }
}
