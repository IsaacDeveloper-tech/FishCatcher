using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Bonus
{
    Add,
    Multiplie
}


[CreateAssetMenu(fileName = "PowerUpData", menuName = "ScriptableObjects/PowerUp", order = 1)]
public class PowerUp : ScriptableObject
{

    [Header("Basic Data of Power Up")]
    public string namePU;
    public float basePrice;
    public float multiplier;
    public string description;
    public Bonus typeOfBonus;

    [Header("This bonus change this values")]
    public List<FloatType> attributeToApplyBonus = new List<FloatType>();

    [Header("Aspect of Item")]
    public Sprite icon;


    private float numOfPowerUps;

    public void ApplyBonus()
    {

        switch (typeOfBonus)
        {
            case Bonus.Add:
                SetAddedBonus();
                break;
            case Bonus.Multiplie:
                SetMultipliedBonus();
                break;
        }

        AddPowerUp();

    }




    private void SetMultipliedBonus()
    {
        for (int i = 0; i < attributeToApplyBonus.Count; i++)
        {
            attributeToApplyBonus[i].runtimeValue = attributeToApplyBonus[i].value * multiplier;
        }
    }


    private void SetAddedBonus()
    {
        for (int i = 0; i < attributeToApplyBonus.Count; i++)
        {
            attributeToApplyBonus[i].runtimeValue = attributeToApplyBonus[i].value + multiplier;
        }
    }


    public void AddPowerUp()
    {
        numOfPowerUps++;
    }

    public void SubtractPowerUp()
    {
        //code
    }

}
