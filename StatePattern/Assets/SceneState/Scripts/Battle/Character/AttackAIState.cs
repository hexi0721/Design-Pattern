using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAIState : AIStateBase
{
    private ICharacter atkTarget;

    public AttackAIState(ICharacter atkTarget)
    {
        this.atkTarget = atkTarget;
    }

    public override void SelfUpdate(List<ICharacter> targets)
    {
        if(atkTarget == null || atkTarget.IsKilled || targets == null || targets.Count == 0)
        {
            ai.ChangeAIState(new IdleAIState());
            return;
        }

        if(ai.IsTargetInAtkRange(atkTarget) == false)
        {
            ai.ChangeAIState(new ChaseAIState(atkTarget));
            return;
        }

        ai.Attack(atkTarget);
    }

    public override void RemoveTarget(ICharacter target)
    {
        if(atkTarget.Name == target.Name)
        {
            atkTarget = null;
        }
    }
}
