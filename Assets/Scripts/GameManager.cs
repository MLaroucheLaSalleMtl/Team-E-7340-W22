using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BeatScroll BS;
    public bool strtToPlaying;
    public static GameManager instance;
    public string txtScore;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!strtToPlaying)
        {
            if (Input.anyKeyDown)
            {
                strtToPlaying = true;
                BS.started = true;
            }
        }
    }
    public void hitNote()
    {
        Debug.Log("Good Hit");
    }
    public void missedNote()
    {
        Debug.Log("Missed Hit");
    }
}
