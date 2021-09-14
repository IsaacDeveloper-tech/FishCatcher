using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "floatvalue", menuName = "ScriptableObjects/FloatType")]
[System.Serializable]
public class FloatType : ScriptableObject, ISerializationCallbackReceiver
{
    public float value;

    [System.NonSerialized]
    public float runtimeValue;

    public void OnAfterDeserialize()
    {
        runtimeValue = value;
    }

    public void OnBeforeSerialize()
    {
        
    }
}
