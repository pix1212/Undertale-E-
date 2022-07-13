using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string currentMapName;
    Rigidbody2D rigidbody2D;
    public float moveSpeed;
    

    
    
    Animator animator;
    
    
    bool playerMoving;
    Vector2 vector;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vector.x = Input.GetAxisRaw("Horizontal");
        vector.y = Input.GetAxisRaw("Vertical");

        
        
    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = vector.normalized * moveSpeed;

        /*
        if(vector.x != 0 || vector.y !=0)
        {
            

            if(vector.x != 0 && vector.y !=0)
            {

            }

            
        }
        else
        {

        }
        */
        
        
    }
    
}

