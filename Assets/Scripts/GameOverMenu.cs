using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    GameManager gm;

    // Update is called once per frame
    public void QTM()
    {
        SceneManager.LoadScene(0);
    }
    public void RB()
    {
        SceneManager.LoadScene(4);
    }
   
   

}
