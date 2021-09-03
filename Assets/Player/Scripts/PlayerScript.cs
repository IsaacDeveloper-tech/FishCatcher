using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float maxFishes;
    public float fishes;
    public float money;


    public GathererScript collector;


    void Start()
    {
        StartCoroutine("Tick");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Tick()
    {

        float temp;

        while (true)
        {
            temp = 0;
            yield return new WaitForSeconds(1);

            temp = fishes + collector.GetFishes();

            if (temp < maxFishes)
            {
                fishes = temp;
            }
            else{
                fishes = maxFishes;
            }
        }
    }
}
