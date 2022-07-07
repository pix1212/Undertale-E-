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

        if(startPoint == thePlayer.currentMapName)
        {
            
            thePlayer.transform.position = this.transform.position;
        }
    }

}
