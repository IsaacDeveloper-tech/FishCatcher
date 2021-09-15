using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellFishSystem : MonoBehaviour
{
    public FloatType fishes;

    public FloatType sellMultiplier;

    public FloatType money;

    [Header("Events")]
    public Event onSellFishes;

    public void SellFishes()
    {
        money.runtimeValue += fishes.runtimeValue * sellMultiplier.runtimeValue;
        fishes.runtimeValue = 0;
        onSellFishes.Raise();
    }
}
