using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingButton : MonoBehaviour
{

    public GameObject Lives;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D destroy)
    {
        if(destroy.gameObject.name  == "Lives")
        {
            Destroy(destroy.gameObject);
            Debug.Log("destroyed");
        }
    }
    
    
}
