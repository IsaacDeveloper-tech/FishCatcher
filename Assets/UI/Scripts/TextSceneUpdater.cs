using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSceneUpdater : MonoBehaviour
{
    public TextMeshPro textToUpdate;

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
