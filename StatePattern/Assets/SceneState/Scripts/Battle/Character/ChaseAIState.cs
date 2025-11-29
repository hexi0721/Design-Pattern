using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAIState : AIStateBase
{
    private ICharacter chaseTarget;
    private Vector3 chasePos;
    private bool isChasing;
    private const float ChaseCheckDist = 0.2f;

    public ChaseAIState(ICharacter chaseTarget)
    {
        this.chaseTarget = chaseTarget;
        isChasing = false;
    }

    public override void SelfUpdate(List<ICharacter> targets)
    {
        if(chaseTarget == null || chaseTarget.IsKilled)
        {
            ai.ChangeAIState(new IdleAIState());
            return;
        }

        if(ai.IsTargetInAtkRange(chaseTarget))
        {
            ai.StopMove();
            ai.ChangeAIState(new AttackAIState(chaseTarget));
            return;
        }

        if(isChasing)
        {
            float dist = Vector3.Distance(chasePos, ai.GetPos());
            if(dist < ChaseCheckDist)
            {
                ai.ChangeAIState(new IdleAIState());
            }
            return;
        }

        isChasing = true;
        chasePos = chaseTarget.GetPosition();
        ai.MoveTo(chasePos);

    }

    public override void RemoveTarget(ICharacter target)
    {
        if(chaseTarget.Name == target.Name)
        {
            chaseTarget = null;
        }
    }

}