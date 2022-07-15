using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IPlayerState state;
    public IFuncState curFunState;
    public FunStandState funStandState;
    public FunMoveState funMoveState;
    public FunAttackState funAttackState;
    
    public string currentMapName;
    public float moveSpeed;


    Rigidbody2D rigidbody2D;
    Animator animator;

    Vector2 vector;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();

        state = new StandState();
        state.OnChangeState += ChangeState;

        funStandState = new FunStandState(this);
        funMoveState = new FunMoveState(this);
        funAttackState = new FunAttackState(this);

        curFunState = funStandState;
    }

    void Update()
    {
        state.Excute();
        GetInput();
    }

    void FixedUpdate()
    {
        //curFunState.Move();
        Move();
    }

    void Move()
    {
        //animator.SetBool("Walking", true);

        rigidbody2D.velocity = vector.normalized * moveSpeed;

        if(vector.x !=0)
        {
            animator.SetBool("Walking", true);
            animator.SetFloat("DirX", vector.x);
            animator.SetFloat("DirY", 0.0f);
            
        }
        
        /*
        if(vector.y != 0)
        {
            animator.SetBool("Walking", true);
            animator.SetFloat("DirX", 0.0f);
            animator.SetFloat("DirY", vector.y);
        }
        */
    }

    void GetInput()
    {
        vector.x = Input.GetAxisRaw("Horizontal");
        vector.y = Input.GetAxisRaw("Vertical");
    }

    void ChangeState(PlayerState newState)
    {
        state.OnChangeState-= ChangeState;

        if (newState == PlayerState.Stand)
        {
            state = new StandState();
        }
        else if (newState == PlayerState.Move)
        {
            state = new MoveState();
        }
        
        state.OnChangeState += ChangeState;
    }

    public void ChangeFunState(IFuncState nextState)
    {
        curFunState = nextState;
    }
}

