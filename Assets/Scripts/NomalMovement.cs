using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalMovement : MonoBehaviour, IMovement
{
    PlayerController player;

    void Start()
    {
        player = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        
    }
}
