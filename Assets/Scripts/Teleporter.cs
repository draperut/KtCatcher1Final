using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    
    // Start is called before the first frame update
  

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Winner1")
        {
            SceneManager.LoadScene("Level 2"); 
        }
        if(collider.gameObject.tag == "Winner2")
        {
            SceneManager.LoadScene("Level 3");
        }
        if(collider.gameObject.tag == "Winner3")
        {
            SceneManager.LoadScene("Level 4");
        }
        if(collider.gameObject.tag == "Winner4")
        {
            SceneManager.LoadScene("Level 5");
        }
        if(collider.gameObject.tag == "Winner5")
        {
            SceneManager.LoadScene("Final Level");
        }
        if(collider.gameObject.tag == "TurtleJR")
        {
            SceneManager.LoadScene("YOU FOUND HIM");
        }
        
    }
}
