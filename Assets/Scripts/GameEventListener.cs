using UnityEngine;
using UnityEngine.Events;
//From the Talk by Ryan Hipple at Austin Unite 2017
// "Game Architecture with Scriptable Objects"

public class GameEventListener : MonoBehaviour
{
  //What channel am I listening to?
  public GameEventChannel eventChannelToListenTo;

  //What do I do when I hear this event?
  public UnityEvent responseToGameEvent;
  public void OnEnable()
  {
    eventChannelToListenTo.RegisterListener(this);
  }
  public void OnEventRaised()
  {
    responseToGameEvent.Invoke();
  }
  public void OnDisable()
  {
    eventChannelToListenTo.DeregisterListener(this);
  }
}
