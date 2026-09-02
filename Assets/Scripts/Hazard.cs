using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{      
    public GameObject HealthBar;
     public GameObject[] hearts;
    private int lives = 3;
    private float timer = 0;

    
       void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
print("Got to OnTriggerEnter2D");
        if(other.GetComponent<Collider2D>().gameObject.tag == "Hurty")
        {
            HurtPlayer();
        } else if (other.GetComponent<Collider2D>().CompareTag("Lethal"))
        {
            LethalPlayer();
        }
    }
    public void HurtPlayer()
    {
print("Got to HurtPlayer()");
        if(timer <= 0){
            timer = 3;
            lives -= 1;
            hearts[lives].SetActive(false);
            if(lives == 0)
            {
                SceneManager.LoadScene("Level 1");
                return;
            }   
        }
    }
    public void LethalPlayer()
    {
print("Got to LethalPlayer()");
        if(timer <= 0) {
            timer = 3;
            lives = 0;
            for(int i = 0; i < hearts.Length; i++)
            {
                hearts[i].SetActive(false);
            }

            SceneManager.LoadScene("Level 1");
        }
    }

    
}
