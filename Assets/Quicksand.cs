using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quicksand : MonoBehaviour
{
    public Movement movement;
    public Jump jump;

    public void SlowPlayer()
    {
     movement.speed = 5;    
    }
    public void SlowerPlayer()
    {
    movement.speed = 2; 
    }   




   private void OnTriggerEnter2D(Collider2D other)
{


    if (other.CompareTag("Sandy"))
    {
        SlowPlayer();
        Debug.Log("Sandy Entered");
    }
    else if (other.CompareTag("ReallySandy"))
    {
        SlowerPlayer();
    }
}
private void OnTriggerExit2D(Collider2D other){
    movement.speed = 10;
}

}