using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : RaycastController
{
    public CollisionInfo collision;

    public override void Awake()
    {
        base.Awake();
        collision.Reset();
    }

    public override void Update()
    {
        base.Update();
    }

    public enum PlayerPositionState
    {
        Ground,
        Ceiling,
        RightWall,
        LeftWall
    }

    public PlayerPositionState GetPlayerPositionState()
    {
        return PlayerPositionState.Ground;
    }
}
