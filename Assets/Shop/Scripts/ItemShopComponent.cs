using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopComponent : MonoBehaviour
{
    [Header("PowerUp Configuration")]
    public PowerUp powerup;

    [Header("MoneySystem")]

    //Components
    private SpriteRenderer render;


    void Start()
    {

        //Create SpriteComponent to show powerup sprite
        gameObject.AddComponent<SpriteRenderer>();
        render = GetComponent<SpriteRenderer>();
        render.sprite = powerup.icon;
    }

    public void BuyPowerUp()
    {
        powerup.AddPowerUp();
    }

}
