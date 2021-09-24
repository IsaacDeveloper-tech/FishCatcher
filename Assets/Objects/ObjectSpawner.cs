using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [Header("Object to spawn")]

    public GameObject obj;

    [Header("Configuration")]

    public float timeToSpawn;

    [Header("Area to spawn")]

    public Vector2 areaPosition;
    public float x;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        if (obj != null)
        {
            StartCoroutine("Spawn");
        }
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);

            float xAxis = Random.Range(-x / 2, x / 2);
            float yAxis = Random.Range(-y / 2, y / 2);

            GameObject objSpawned = Instantiate(obj);
            objSpawned.transform.position = new Vector3(xAxis, yAxis, 0) + (Vector3)areaPosition;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(areaPosition, new Vector3(x, y, 0));
    }
}
