using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
  //  public GameObject Destroyobj;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                
                GameManager.instance.hitNote();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Activate")
        {
            canBePressed = true;
            GameManager.scoreValue += 100;
        }
    }
    
       
    
    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.tag == "Activate")
        {
            canBePressed = false;
            if (!canBePressed)
            {
                Destroy(gameObject);
            }
            GameManager.scoreValue -= 100;
            GameManager.instance.health -= 1;
            GameManager.instance.missedNote();
        }
      
        
    }
   // private void OnCollisionEnter2D(Collision2D collision)
   // {
      //  if(collision.gameObject.name == "DestroyingButtons")
      //  {
        //    Destroy(gameObject);
       // }
   // }



}
