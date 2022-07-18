using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public IPlayerState state;
    public float moveSpeed;


    Rigidbody2D rigidbody2D;
    Animator animator;

    Vector2 vector;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();

        //state = new IdleState();
        //state.OnChangeState += ChangeState;

    }

    void Update()
    {
        //state.Excute();
        GetInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rigidbody2D.velocity = vector.normalized * moveSpeed;

        
        if(vector.x == 0 || vector.y == 0)
        {
            animator.SetBool("Walking", false);
        }
        

        if(vector.x != 0)
        {
            if(vector.y != 0)
            {
                return;
            }
            animator.SetBool("Walking", true);
            animator.SetFloat("DirX", vector.x);
            animator.SetFloat("DirY", 0.0f);
        }

        if(vector.y != 0)
        {
            if(vector.x != 0 )
            {
                return;
            } 

            animator.SetBool("Walking", true);
            animator.SetFloat("DirX", 0.0f);
            animator.SetFloat("DirY", vector.y);
        }
    }




    void GetInput()
    {
        
        vector.x = Input.GetAxisRaw("Horizontal");
        vector.y = Input.GetAxisRaw("Vertical");

    }

/*
    void ChangeState(PlayerState newState)
    {
        state.OnChangeState-= ChangeState;

        if (newState == PlayerState.Conversation)
        {
            state = new ConversationState();
        }
        else if (newState == PlayerState.Battel)
        {
            state = new BattelState();
        }
        else if (newState == PlayerState.Dead)
        {
            state = new DeadState();
        }
        else if (newState == PlayerState.Idle)
        {
            state = new IdleState();
        }
        
        state.OnChangeState += ChangeState;
    }
    */
}

