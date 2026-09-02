using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FlippyCamera : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public int dutchAngle = 0;
    public Movement movement;
    public Jump jump;

        private void Awake()
    {
        if (vcam == null)
        {
            vcam = FindObjectOfType<CinemachineVirtualCamera>();
        }
    }


   private void OnTriggerEnter2D(Collider2D other)
{
    
    if(other.CompareTag("Trick"))
    {
        var lens = vcam.m_Lens;  
        dutchAngle = 180; 
        lens.Dutch = dutchAngle;  
        vcam.m_Lens = lens;
       
}
}

}