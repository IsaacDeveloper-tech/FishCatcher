using System.Collections;
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

    [Header("Shop Config")]
    public FloatType multipliePrice;
    


    void Start()
    {
        numOfItems.text = "X" + powerup.GetNumOfPowerUps().ToString();
        price.text = powerup.basePrice.ToString();
        mainSprite.sprite = powerup.icon;
    }

    public void BuyPowerUp()
    {
        numOfItems.text = "X" + powerup.GetNumOfPowerUps().ToString();
        powerup.ApplyBonus();
    }

}
