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
    public FloatType basePrice;
    public FloatType multiplier;
    [TextArea]public string description;
    public Bonus typeOfBonus;
    public FloatType numOfPowerUps;

    [Header("This bonus change this values")]
    public List<FloatType> attributeToApplyBonus = new List<FloatType>();

    [Header("Aspect of Item")]
    public Sprite icon;


    

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

    }




    private void SetMultipliedBonus()
    {
        for (int i = 0; i < attributeToApplyBonus.Count; i++)
        {
            attributeToApplyBonus[i].runtimeValue = attributeToApplyBonus[i].runtimeValue * multiplier.runtimeValue;
        }
    }


    private void SetAddedBonus()
    {
        for (int i = 0; i < attributeToApplyBonus.Count; i++)
        {
            attributeToApplyBonus[i].runtimeValue = attributeToApplyBonus[i].runtimeValue + multiplier.runtimeValue;
        }
    }

    public float GetNumOfPowerUps()
    {
        return numOfPowerUps.runtimeValue;
    }

    public void SubtractPowerUp()
    {
        //code
    }

}
