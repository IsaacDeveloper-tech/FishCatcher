using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

[Serializable]
public struct Data
{
    [SerializeField]
    public float[] floats;
}



public class SaveSystem : MonoBehaviour
{
    private string path;
    private Data runtimeData;

    public List<FloatType> data = new List<FloatType>();

    private void Awake()
    {
        PrepareArrayData();

        path = Application.persistentDataPath + "/gamedata.txt";
        LoadData();
    }

    private void PrepareArrayData()
    {
        runtimeData.floats = new float[data.Count];
    }

    public void SaveData()
    {

        StreamWriter writer = new StreamWriter(path);

        for (int i = 0; i < runtimeData.floats.Length; i++)
        {
            runtimeData.floats[i] = data[i].runtimeValue;
        }

        string temp = JsonUtility.ToJson(runtimeData);
        writer.Write(temp);

        writer.Close();

        Debug.Log(temp);

    }

    public void LoadData()
    {
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);

            string temp = reader.ReadToEnd();

            reader.Close();

            Data tempData = JsonUtility.FromJson<Data>(temp);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].runtimeValue = tempData.floats[i];
            }
        }
    }
}
