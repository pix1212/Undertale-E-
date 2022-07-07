using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public GameObject tPlayer;
    public Transform target;
    private CinemachineVirtualCamera vcam;
    
    void Start(){
        vcam = GetComponent<CinemachineVirtualCamera>();
        tPlayer = null;
    }
    
    void Update(){
        if (tPlayer == null){
            tPlayer = GameObject.FindWithTag("Player");
            if (tPlayer != null){
                target = tPlayer.transform;
                vcam.Follow = target;
            }
        }
    }
    
}
