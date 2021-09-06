using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "floatvalue", menuName = "Values/FloatType")]
public class FloatType : ScriptableObject, ISerializationCallbackReceiver
{
    public float value;

    public float runtimeValue;

    public void OnAfterDeserialize()
    {
        runtimeValue = value;
    }

    public void OnBeforeSerialize()
    {
        
    }
}
