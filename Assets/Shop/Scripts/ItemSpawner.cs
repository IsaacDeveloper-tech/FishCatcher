using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour, IFactory
{
    [Header("PowerUps Configuration")]
    public List<PowerUp> powerUps = new List<PowerUp>();

    [Header("Skeleton")]
    public GameObject skeleton;

    // Start is called before the first frame update
    void Start()
    {
        Create();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Create()
    {
        ItemShopComponent component = skeleton.GetComponent<ItemShopComponent>();

        GameObject temp = null;

        for (int i = 0; i < powerUps.Count; i++)
        {
            component.powerup = powerUps[i];

            temp = Instantiate(skeleton);

            

            temp.transform.SetParent(transform);
        }
    }

}
