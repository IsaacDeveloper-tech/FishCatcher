using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameEvent", menuName = "ScriptableObjects/Event")]
public class Event : ScriptableObject
{
    private List<EventListener> listeners = new List<EventListener>();

    public void RegisterListener(EventListener plistener)
    {
        if (!listeners.Contains(plistener))
        {
            listeners.Add(plistener);
        }
    }

    public void UnregisterListener(EventListener plistener)
    {
        if (listeners.Contains(plistener))
        {
            listeners.Remove(plistener);
        }
    }

    public void Raise()
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }
    }
}
