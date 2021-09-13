using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PanelInfoData", menuName = "OtherScriptableObjects/InfoPanelData")]
public class ShopInfoPanelData : ScriptableObject
{
    private string title;
    private string info;
    private Sprite sprite;

    public string GetTitle()
    {
        return title;
    }

    public string GetInfo()
    {
        return info;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }


    public void SetTitle(string ptitle)
    {
        title = ptitle;
    }

    public void SetInfo(string pinfo)
    {
        info = pinfo;
    }

    public void SetSprite(Sprite psprite)
    {
        sprite = psprite;
    }
}
