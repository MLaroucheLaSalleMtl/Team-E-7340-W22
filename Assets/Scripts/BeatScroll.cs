using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroll : MonoBehaviour
{
    public float Tempo;
    public bool started;

    // Start is called before the first frame update
    void Start()
    {
        Tempo = Tempo / 30f;

    }

    // Update is called once per frame
    void Update()
    {
       if(!started)
       {
            if (Input.anyKeyDown)
            {
                started = true;
            }

       }
       else
       {
            transform.position -= new Vector3( Tempo * Time.deltaTime, 0f);
       }
    }
}
