using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "shop", menuName = "ScriptableObjects/shop")]
public class Shop : ScriptableObject
{
    public List<PowerUp> powerUps = new List<PowerUp>();
}
