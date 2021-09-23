using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class ObjectSystem : MonoBehaviour
{
    [Header("Animation")]
    public RuntimeAnimatorController animatorController;

    [Header("Configuration")]
    public float speed;

    [Header("Way of object")]
    public Vector2[] way;


    private Animator anim;
    private SpriteRenderer sprite;

    private int countWayPoint;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        if (way.Length > 0)
        {
            countWayPoint = 1;
            transform.position = way[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (way.Length > 0)
        {
            WalkWay();
        }
    }

    private void WalkWay()
    {
        if (Vector2.Distance(transform.position, way[countWayPoint]) < .01f)
        {
            countWayPoint++;
        }

        if (countWayPoint >= way.Length)
        {
            countWayPoint = 0;
        }

        transform.Translate((way[countWayPoint] - (Vector2)transform.position).normalized * speed * Time.deltaTime);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position, .5f);

        Gizmos.color = Color.red;
        if (way.Length > 0)
        {
            for (int i = 0; i < way.Length; i++)
            {
                Gizmos.DrawSphere(way[i], .1f);
                if (i + 1 < way.Length)
                {
                    Gizmos.DrawLine(way[i], way[i + 1]);
                }
                else
                {
                    Gizmos.DrawLine(way[i], way[0]);
                }
            }
        }
    }
}
