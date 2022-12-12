using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
      Cursor.lockState = CursorLockMode.None;
      Debug.Log("START GAME!");
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      //SceneManager.UnloadSceneAsync("MainMenu");
    }

    public void QuitGame ()
    {
      Debug.Log("QUIT!");
      Application.Quit();
    }
}
