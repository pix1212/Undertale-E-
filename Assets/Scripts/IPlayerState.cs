using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum PlayerState {Conversation, Battel, Dead, Idle}

public interface IPlayerState
{
    event UnityAction<PlayerState> OnChangeState;
    void Excute();
}

public class ConversationState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {
        
    }
}

public class BattelState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {
        
    }
}

public class DeadState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {

    }
}

public class IdleState : IPlayerState
{
    public event UnityAction<PlayerState> OnChangeState;

    public void Excute()
    {

    }
}