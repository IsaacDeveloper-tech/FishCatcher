using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObjectSystem : MonoBehaviour
{

    [Space]
    [Header("Configuration")]

    public int extraPoints;

    [Space]
    [Header("Components")]

    public FloatType attributeToChange;
    public Event clickEvent;

    [Space]
    [Header("Particles")]

    public GameObject particles;

    //private attributes
    private Camera cam;

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Detection();
        }

    }

    private void Detection()
    {
        RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag(gameObject.tag))
            {
                attributeToChange.runtimeValue += extraPoints;

                if (particles != null)
                {
                    DisplayParticles();
                }

                clickEvent.Raise();

                Destroy(hit.collider.gameObject.transform.parent.gameObject);
            }
        }

    }

    private void DisplayParticles()
    {
        GameObject obj = Instantiate(particles);
        obj.transform.position = transform.position;
    }
}
