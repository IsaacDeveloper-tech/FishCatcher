using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextUpdater : MonoBehaviour
{
    public TextMeshProUGUI textToUpdate;

    public FloatType value;

    private void Update()
    {
        UpdateFishCounter();
    }

    public void UpdateFishCounter()
    {
        textToUpdate.text = Mathf.Round(value.runtimeValue).ToString();

        if (value.runtimeValue >= 1000)
        {
            textToUpdate.text = Mathf.Round(value.runtimeValue / 1000).ToString() + "K";
        }

        if (value.runtimeValue >= 1000000)
        {
            textToUpdate.text = Mathf.Round(value.runtimeValue / 1000000).ToString() + "M";
        }

        if (value.runtimeValue >= 1000000000)
        {
            textToUpdate.text = Mathf.Round(value.runtimeValue / 1000000000).ToString() + "B";
        }

        if (value.runtimeValue >= 1000000000000)
        {
            textToUpdate.text = Mathf.Round(value.runtimeValue / 1000000000000).ToString() + "T";
        }
    }
}
