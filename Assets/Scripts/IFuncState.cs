using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFuncState
{
    void Stand();
    void Move();
    void Attack();
}

public class FunStandState : IFuncState
{
    PlayerController player;

    public FunStandState(PlayerController player)
    {
        this.player = player;
    }

    public void Stand()
    {
        // Stand
    }

    public void Move()
    {
        player.ChangeFunState(player.funMoveState);
    }
    public void Attack()
    {
        player.ChangeFunState(player.funAttackState);
    }
}

public class FunMoveState : IFuncState
{
    PlayerController player;

    public FunMoveState(PlayerController player)
    {
        this.player = player;
    }

    public void Stand()
    {
        player.ChangeFunState(player.funStandState);
    }
    public void Move()
    {
        // Move
    }
    public void Attack()
    {
        player.ChangeFunState(player.funAttackState);
    }
}

public class FunAttackState : IFuncState
{
    PlayerController player;

    public FunAttackState(PlayerController player)
    {
        this.player = player;
    }

    public void Stand()
    {

    }
    public void Move()
    {

    }
    public void Attack()
    {

    }
}
