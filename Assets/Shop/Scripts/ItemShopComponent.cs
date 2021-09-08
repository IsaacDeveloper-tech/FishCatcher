using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemShopComponent : MonoBehaviour
{
    [Header("PowerUp Configuration")]
    public PowerUp powerup;

    [Header("Image Components")]
    public Sprite mainSprite;

    [Header("Text components")]
    public TextMeshProUGUI numOfItems;
    public TextMeshProUGUI price;


    void Start()
    {

    }

    public void BuyPowerUp()
    {
        powerup.AddPowerUp();
    }

}
