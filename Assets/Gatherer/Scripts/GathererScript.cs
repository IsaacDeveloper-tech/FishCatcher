using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GathererScript : MonoBehaviour
{

    public float fishPerSecondBase;
    public float multiplier;

    public void IncreaseMultiplier(float pmultiplier)
    {
        multiplier += pmultiplier;
    }

    public float GetFishes()
    {
        return fishPerSecondBase * multiplier;
    }
}
