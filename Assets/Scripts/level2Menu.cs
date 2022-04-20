using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level2Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void QTM()
    {
        SceneManager.LoadScene(0);
    }
    public void RB()
    {
        SceneManager.LoadScene(4);
    }
}
