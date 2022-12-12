using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
  [SerializeField] public GameObject HowToPlayMenu;
  [SerializeField] public GameObject MainMenu;

  public void Return()
  {
    MainMenu.SetActive(true);
    HowToPlayMenu.SetActive(false);
    Cursor.lockState = CursorLockMode.None;
  }

  public void TutorialScreen()
  {
    HowToPlayMenu.SetActive(true);
    MainMenu.SetActive(false);
    Cursor.lockState = CursorLockMode.None;
  }
}
