using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GathererScript : MonoBehaviour
{

    public FloatType fishPerSecondBase;
    public FloatType multiplier;

    public void IncreaseMultiplier(float pmultiplier)
    {
        multiplier.runtimeValue += pmultiplier;
    }

    public float GetFishes()
    {
        return fishPerSecondBase.runtimeValue * multiplier.runtimeValue;
    }
}
