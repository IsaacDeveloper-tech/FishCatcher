using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementSystem : MonoBehaviour
{
    [Space]
    [Header("Waypoints")]

    public Transform[] waypoints;

    [Space]
    [Header("Configuration")]
    [Tooltip("If use physics only can have 2 waypoints")]
    public bool usePhysics;
    public float speed;
    public bool flip;

    [Space]
    [Header("Gizmos Configuration")]
    public Color gizmoColor;
    public float pointsRadius;


    //private attributes
    private Rigidbody2D physics;
    private int wayCount;

    private void Awake()
    {
        if (usePhysics)
        {
            physics = GetComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        if (!usePhysics)
        {
            if (Vector2.Distance(transform.position, waypoints[wayCount].position) < .2f)
            {
                wayCount++;
            }

            if (wayCount >= waypoints.Length)
            {
                wayCount = 0;
            }

            if (waypoints[wayCount].position.x < transform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            transform.Translate((waypoints[wayCount].position - transform.position).normalized * speed * Time.deltaTime);
        }
    }


    private void FixedUpdate()
    {
        if (usePhysics)
        {
            if (waypoints.Length > 0)
            {
                if (Mathf.Abs(waypoints[wayCount].position.x - transform.position.x) < .5f)
                {
                    wayCount++;
                }

                if (wayCount >= waypoints.Length)
                {   
                    wayCount = 0;
                }


                if (waypoints[wayCount].position.x < transform.position.x)
                {
                    physics.velocity = new Vector2(-1 * speed, physics.velocity.y);
                    transform.localScale = new Vector3(1, 1, 1);
                }
                else
                {
                    physics.velocity = new Vector2(1 * speed, physics.velocity.y);
                    transform.localScale = new Vector3(-1, 1, 1);
                }

            }

            //physics.AddForce(new Vector2(((waypoints[wayCount].position.x - transform.position.x) / (waypoints[wayCount].position.x - transform.position.x)) * speed, 0));

        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;

        if (waypoints.Length > 0)
        {
            for (int i = 0; i < waypoints.Length; i++)
            {
                Gizmos.DrawSphere(waypoints[i].position, pointsRadius);

                if (i + 1 < waypoints.Length)
                {
                    Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
                }
                else
                {
                    Gizmos.DrawLine(waypoints[i].position, waypoints[0].position);
                }
            }
        }
        
    }
}
