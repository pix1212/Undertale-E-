using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public IPlayerState state;
    public float moveSpeed;
    bool isActing;

    Rigidbody2D rigidbody2D;
    Animator animator;

    Vector2 vector;
    Vector3 playerDir;


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
        Action();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (isActing)
            return;

        rigidbody2D.velocity = vector.normalized * moveSpeed;

        
        if(vector.x == 0 || vector.y == 0)
        {
            animator.SetBool("Walking", false);
        }
        

        if(vector.x != 0)
        {
            if(vector.x > 0)
            playerDir = Vector3.right;

            else if(vector.x < 0)
            playerDir = Vector3.left;
            
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
            if(vector.y > 0)
            playerDir = Vector3.up;
            
            else if(vector.y < 0)
            playerDir = Vector3.down;

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
    
    void Action()
    {
        Debug.DrawRay(rigidbody2D.position, playerDir * 16.0f, Color.red);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2D.position, playerDir, 16.0f, LayerMask.GetMask("NPC"));
            
            if(null != hit.collider)
            {
                IInterAction target = hit.collider.gameObject.GetComponent<IInterAction>();
                if(null != target)
                {
                    isActing = target.ReAction();
                    return;
                }

            }
            
            
        }
        

        
        

        
    }
}

