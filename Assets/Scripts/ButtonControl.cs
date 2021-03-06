using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    private SpriteRenderer SR;
    public Sprite defaultImg;
    public Sprite pressedImg;

    public KeyCode keytoPress;

    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keytoPress))
        {
            SR.sprite = pressedImg;

        }
        if (Input.GetKeyDown(keytoPress))
        {
            SR.sprite = defaultImg;
        }
    }
}
