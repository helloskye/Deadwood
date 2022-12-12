using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneChange : MonoBehaviour
{
  [SerializeField] public string SceneName;
  public void OpenDoor()
  {
    SceneManager.LoadScene(SceneName);
  }
}
