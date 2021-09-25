using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [Header("Object to spawn")]

    public GameObject obj;

    [Header("Configuration")]

    public float timeToSpawn;
    public int initialInstantiaton;
    public bool setRandomColor;

    [Header("Area to spawn")]

    public Vector2 areaPosition;
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        if (obj != null)
        {
            StartCoroutine("SpawnIterator");
        }

        for (int i = 0; i < initialInstantiaton; i++)
        {
            Spawn();
        }
    }

    IEnumerator SpawnIterator()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            Spawn();
        }
    }

    private void Spawn()
    {


        float xAxis = Random.Range(-x / 2, x / 2);
        float yAxis = Random.Range(-y / 2, y / 2);

        GameObject objSpawned = Instantiate(obj);

        if (setRandomColor)
        {
            switch ((int)Random.Range(0,4))
            {
                case 0:
                    objSpawned.GetComponentInChildren<SpriteRenderer>().color = Color.red;
                    break;
                case 1:
                    objSpawned.GetComponentInChildren<SpriteRenderer>().color = Color.yellow;
                    break;
                case 2:
                    objSpawned.GetComponentInChildren<SpriteRenderer>().color = Color.blue;
                    break;
            }

            /*objSpawned.GetComponentInChildren<SpriteRenderer>().color = new Color(
                    Random.Range(100, 200),
                    Random.Range(150, 250),
                    Random.Range(0, 1)
               );*/
        }

        objSpawned.transform.position = new Vector3(xAxis, yAxis, 0) + (Vector3)areaPosition;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(areaPosition, new Vector3(x, y, 0));
    }
}
