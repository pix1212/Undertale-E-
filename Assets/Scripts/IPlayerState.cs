using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum PlayerState {Stand, Move, Conversation}

public interface IPlayerState
{
    event UnityAction<PlayerState> OnChangeState;
    void Excute();
}

public class StandState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {
        //가만히 있는 애니메이션 재생

        if (Input.GetAxisRaw("Horizontal") > 0 || Input.GetAxisRaw("Vertical") > 0)
        {
            OnChangeState.Invoke(PlayerState.Move);
        }
        
    }
}

public class MoveState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {
        //player move

        if (Input.GetAxisRaw("Horizontal") == 0 || Input.GetAxisRaw("Vertical") == 0)
        {
            OnChangeState.Invoke(PlayerState.Stand);
        }
    }
}

public class ConversationState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {

    }
}