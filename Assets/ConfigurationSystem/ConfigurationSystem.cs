using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationSystem : MonoBehaviour
{

    private bool show;

    private Vector2 hideScale;
    private Vector2 showScale;

    private float speedAnim;

    public RectTransform trans;

    private void Awake()
    {
        hideScale = new Vector3(0, 0, 0);
        showScale = new Vector3(1, 1, 1);
        speedAnim = .2f;
    }

    private void Update()
    {
        if (show)
        {
            trans.localScale = Vector3.Lerp(trans.localScale, showScale, speedAnim);
        }
        else
        {
            trans.localScale = Vector3.Lerp(trans.localScale, hideScale, speedAnim);
        }
    }

    public void Show()
    {
        show = true;
    }


    public void Hidde()
    {
        show = false;
    }

}
