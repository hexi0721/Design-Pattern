using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAIState : AIStateBase
{
    private bool isSetAtkPos;

    public override void SetAttackPos(Vector3 atkPos)
    {
        isSetAtkPos = true;
    }

    public override void SelfUpdate(List<ICharacter> targets)
    {
        if(targets == null || targets.Count == 0)
        {
            if(isSetAtkPos)
            {
                ai.ChangeAIState(new MoveAIState());
            }
            
            return;
        }

        Vector3 nowPos = ai.GetPos();
        ICharacter theNearTarget = null;
        float minDist = float.MaxValue;

        foreach(ICharacter target in targets)
        {
            if(target.IsKilled)
            {
                continue;
            }

            float dist = Vector3.Distance(nowPos, target.GetPosition());

            if(dist < minDist)
            {
                minDist = dist;
                theNearTarget = target;
            }
        }

        if(theNearTarget == null)
        {
            return;
        }

        if(ai.IsTargetInAtkRange(theNearTarget))
        {
            ai.ChangeAIState(new AttackAIState(theNearTarget));
        }
        else
        {
            ai.ChangeAIState(new ChaseAIState(theNearTarget));
        }


    }
}