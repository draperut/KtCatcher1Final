using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeHUD : MonoBehaviour
{
    public GameObject[] hearts;
    private int lives = 3;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
        }
    }

    public void Start()
    {
        // 
    }
    public void HurtPlayer()
    {
        if(timer <= 0){
            timer = 3;
        lives -= 1;
        hearts[lives].SetActive(false);
        if(lives == 0)
        {
            SceneManager.LoadScene(1);       
            return;
        }   
        }
    }
    public void LethalPlayer()
    {
        if(timer <= 0){
            timer = 3;
        lives -= 3;
        hearts[lives].SetActive(false);
        if(lives == 0)
        {
            SceneManager.LoadScene(1);       
            return;
        }   
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Hurty")
        {
            HurtPlayer();
        }
        if(collider.gameObject.tag == "Lethal")
        {
            LethalPlayer();
        }
    }    
 
}
