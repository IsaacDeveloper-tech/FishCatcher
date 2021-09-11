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
        textToUpdate.text = value.runtimeValue.ToString();
    }
}
