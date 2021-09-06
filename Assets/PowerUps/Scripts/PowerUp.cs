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
    public string namePU;
    public float basePrice;
    public float multiplier;
    public int numOfPowerUp;
    public FloatType attributeToApplyBonus;
    public string description;
    public Bonus typeOfBonus;
    public Sprite icon;


    public float GetBonus(float pnum)
    {

        switch (typeOfBonus)
        {
            case Bonus.Add:
                return SetAddedBonus(pnum);
            case Bonus.Multiplie:
                return SetMultipliedBonus(pnum);
            default:
                return 0;
        }

    }

    private float SetMultipliedBonus(float pnum)
    {
        float bonus = pnum;

        for (int i = 0; i < numOfPowerUp; i++)
        {
            bonus *= multiplier;
        }

        return bonus;
    }


    private float SetAddedBonus(float pnum)
    {
        float bonus = pnum;

        for (int i = 0; i < numOfPowerUp; i++)
        {
            bonus += multiplier;
        }

        return bonus > 0 ? bonus : 0;
    }

}
