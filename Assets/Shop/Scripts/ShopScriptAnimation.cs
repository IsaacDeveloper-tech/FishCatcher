using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScriptAnimation : MonoBehaviour
{
    public RectTransform trans;

    private int direction = 1;
    private float posY = 100;


    public void StartAnimation()
    {
        direction = direction == 1 ? -1 : 1;

        StartCoroutine("Anim");
    }

    IEnumerator Anim()
    {
        while (Vector2.Distance(trans.anchoredPosition, new Vector2(trans.anchoredPosition.x, posY * direction)) > .2f)
        {
            yield return new WaitForEndOfFrame();

            trans.anchoredPosition = Vector2.Lerp(trans.anchoredPosition, new Vector2(trans.anchoredPosition.x, posY * direction), .2f);
        }
    }
}
