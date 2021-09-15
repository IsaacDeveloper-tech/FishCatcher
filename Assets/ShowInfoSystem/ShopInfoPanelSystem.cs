using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ShopInfoPanelSystem : MonoBehaviour
{
    [Space]
    [Header("Info data")]
    public ShopInfoPanelData data;

    [Space]
    [Header("Components")]
    public TextMeshProUGUI title;
    public TextMeshProUGUI info;
    public Image image;

    [Space]
    [Header("Events")]
    public Event OnClickButton;

    //List of IEnumerators
    private IEnumerator appear;
    private IEnumerator hidde;

    private void Awake()
    {
        appear = PlayAppearAnimation();
        hidde = PlayHiddeAnimation();
    }


    public void ShowPanel()
    {
        SetInfo();
        StopCoroutine(hidde);
        StartCoroutine(appear);
    }

    public void HiddePanel()
    {
        StopCoroutine(appear);
        StartCoroutine(hidde);
        OnClickButton.Raise();
    }

    private void SetInfo()
    {
        title.text = data.GetTitle();
        info.text = data.GetInfo();
        image.sprite = data.GetSprite();
    }


    IEnumerator PlayAppearAnimation()
    {
        bool endAnimation = false;

        while (!endAnimation)
        {
            yield return new WaitForEndOfFrame();
            PanelAppearAnimation();
        }
    }

    IEnumerator PlayHiddeAnimation()
    {
        bool endAnimation = false;

        while (!endAnimation)
        {
            yield return new WaitForEndOfFrame();
            PanelHiddeAnimation();
        }
    }


    private void PanelAppearAnimation()
    {
        transform.localScale = Vector2.Lerp(transform.localScale, new Vector2(1, 1), .1f);
    }

    private void PanelHiddeAnimation()
    {
        transform.localScale = Vector2.Lerp(transform.localScale, new Vector2(0, 0), .1f);
    }
}
