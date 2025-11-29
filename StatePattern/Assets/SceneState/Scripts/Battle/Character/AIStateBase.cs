using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIStateBase
{
    protected ICharacterAI ai;

    public void SetCharacterAI(ICharacterAI ai)
    {
        this.ai = ai;
    }

    public virtual void SetAttackPos(Vector3 atkPos) {}

    public abstract void SelfUpdate(List<ICharacter> targets);

    public virtual void RemoveTarget(ICharacter target) {}
}
