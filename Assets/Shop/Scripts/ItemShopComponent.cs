﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemShopComponent : MonoBehaviour
{
    [Header("PowerUp Configuration")]
    public PowerUp powerup;

    [Header("Image Components")]
    public Image mainSprite;

    [Header("Text components")]
    public TextMeshProUGUI numOfItems;
    public TextMeshProUGUI price;

    [Header("Other Components")]
    public TextUpdater priceUpdater;

    [Header("Shop Config")]
    public FloatType multipliePrice;
    public FloatType money;
    


    void Start()
    {
        numOfItems.text = "X" + powerup.GetNumOfPowerUps().ToString();
        price.text = powerup.basePrice.runtimeValue.ToString();
        mainSprite.sprite = powerup.icon;
        priceUpdater.value = powerup.basePrice;
    }

    public void BuyPowerUp()
    {
        if (powerup.basePrice.runtimeValue < money.runtimeValue)
        {
            powerup.ApplyBonus();
            SpendMoney();
            IncreaseNumOfItems();
            IncreaseBasePrice();
            UpdateItemValues();
        }
    }

    public void SpendMoney()
    {
        money.runtimeValue -= powerup.basePrice.runtimeValue;
    }

    public void IncreaseNumOfItems()
    {
        powerup.numOfPowerUps.runtimeValue++;
    }

    public void IncreaseBasePrice()
    {
        powerup.basePrice.runtimeValue *= multipliePrice.runtimeValue;
        Debug.Log(powerup.basePrice.runtimeValue);
    }


    public void UpdateItemValues()
    {
        numOfItems.text = "X" + powerup.GetNumOfPowerUps().ToString();
        price.text = powerup.basePrice.runtimeValue.ToString();
    }

}
