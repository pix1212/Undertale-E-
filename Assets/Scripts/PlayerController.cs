using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState{Stend_R, Stend_L, Stend_U, Stend_D, Move_R, Move_L,Move_U, Move_D}
public class PlayerController : MonoBehaviour
{
    public string currentMapName;
    public float moveSpeed;

    PlayerState _state = PlayerState.Stend_D;


    Rigidbody2D rigidbody2D;
    Animator animator;

    Vector2 vector;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vector.x = Input.GetAxisRaw("Horizontal");
        vector.y = Input.GetAxisRaw("Vertical");

        switch(_state)
        {
            case PlayerState.Move_R:
                UpdateMoveR();
                break;
            case PlayerState.Move_L:
                UpdateMoveL();
                break;
            case PlayerState.Move_U:
                UpdateMoveU();
                break;
            case PlayerState.Move_D:
                UpdateMoveD();
                break;
        }

    }

    void FixedUpdate()
    {
        if(vector.x > 0)
        {
            _state = PlayerState.Move_R;
        }
        
    }

    void Move()
    {
        rigidbody2D.velocity = vector.normalized * moveSpeed;
    }

    void UpdateMoveR()
    {
        Move();
        animator.SetBool("isDirX", true);
    }

    void UpdateMoveL()
    {

    }

    void UpdateMoveU()
    {

    }
    void UpdateMoveD()
    {

    }
}

