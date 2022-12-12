using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/GameEventChannel", fileName = "New GameEventChannel")]

public class GameEventChannel : ScriptableObject
{
  public List<GameEventListener> listeners = new List<GameEventListener>();

  public void RaiseEvent()
  {
    for (int i = listeners.Count - 1; i >= 0; i--) //loops through every & each listener
    {
      if (listeners[i] != null) //if there are listeners left/there is currently a listener,
      {
        listeners[i].OnEventRaised(); //The response to the Game Event that we set up in the Inspector in Unity.
      }
    }
  }

  public void RegisterListener(GameEventListener listener) //adds all listeners that aren't already in the list of listeners
  {
    if (!listeners.Contains(listener))
    {
      listeners.Add(listener);
    }
  }

  public void DeregisterListener(GameEventListener listener)
  {
    if (listeners.Contains(listener))
    {
      listeners.Remove(listener);
    }
  }
}
