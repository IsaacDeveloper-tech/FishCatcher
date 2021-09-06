using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public FloatType maxFishes;
    public FloatType fishes;
    public FloatType money;


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

            temp = fishes.runtimeValue + collector.GetFishes();

            if (temp < maxFishes.runtimeValue)
            {
                fishes.runtimeValue = temp;
            }
            else{
                fishes.runtimeValue = maxFishes.runtimeValue;
            }
        }
    }
}
