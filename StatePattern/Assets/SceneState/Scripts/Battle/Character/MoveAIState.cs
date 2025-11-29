using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAIState : AIStateBase
{
    private bool isMoving;
    private Vector3 atkPos;
    private const float MoveCheckDist = 1.5f;

    public MoveAIState()
    {
        isMoving = false;
    }

    public override void SetAttackPos(Vector3 atkPos)
    {
        this.atkPos = atkPos;
    }

    public override void SelfUpdate(List<ICharacter> targets)
    {
        if(targets != null && targets.Count > 0)
        {
            ai.ChangeAIState(new IdleAIState());
            return;
        }

        if(isMoving)
        {
            float dist = Vector3.Distance(atkPos, ai.GetPos());
            if(dist < MoveCheckDist)
            {
                ai.ChangeAIState(new IdleAIState());
                if(ai.IsKilled())
                {
                    ai.CanAttackHeart();
                }
                ai.Killed();
            }
            return;
        }

        isMoving = true;
        ai.MoveTo(atkPos);
    }

}
