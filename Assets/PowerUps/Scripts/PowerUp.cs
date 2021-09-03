using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Bonifications
{
    Sells,
    Gatherer,
    Discounts,
    Capacity
}

[CreateAssetMenu(fileName = "PowerUpData", menuName = "ScriptableObjects/PowerUp", order = 1)]
public class PowerUp : ScriptableObject
{
    public string namePU;
    public float basePrice;
    public float multiplier;
    public string description;
    public Bonifications type;
    public Sprite icon;
}
