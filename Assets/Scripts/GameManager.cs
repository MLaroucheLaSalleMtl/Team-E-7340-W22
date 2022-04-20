using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BeatScroll BS;
    public bool strtToPlaying;
    public static GameManager instance;
    
    public int currentscr = 0;
    public int ScorePerNote = 100;
    public static int scoreValue = 0;
    public Text score;

    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public static bool gameOver;
    public GameObject Boundground;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score.text = "Score:0000";
        
        
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
        if(health == 0)
        {
            gameOver = true;
            Boundground.SetActive(true);
        }
        
       

       
    }
    public void HealthHearts()
    {
        
        

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    public void hitNote()
    {
        Debug.Log("Good Hit");
        currentscr += ScorePerNote;
        score.text = "Score: " + currentscr;
    }
    public void missedNote()
    {
        Debug.Log("Missed Hit");
        HealthHearts();
        
        

        

        
    }
}
