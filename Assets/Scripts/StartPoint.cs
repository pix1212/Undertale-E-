using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class StartPoint : MonoBehaviour
{
    public string startPoint;
    private PlayerController thePlayer;
    

    void Start()
    {
        
        thePlayer = FindObjectOfType<PlayerController>();
        
        thePlayer.transform.position = this.transform.position;
        
    }

}
