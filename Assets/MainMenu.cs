using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
  public void StartGame()
  {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
  }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
