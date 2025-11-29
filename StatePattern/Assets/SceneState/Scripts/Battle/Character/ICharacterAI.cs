using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterAI
{
    public void Init(ICharacter character, Vector3 atkPos);
    public void ChangeAIState(AIStateBase newAIState);
    public void Attack(ICharacter target);
    public bool IsTargetInAtkRange(ICharacter target);
    public Vector3 GetPos();
    public void MoveTo(Vector3 pos);
    public void StopMove();
    public void Killed();
    public bool IsKilled();
    public void RemoveAITarget(ICharacter target);
    public void SelfUpdate(List<ICharacter> targets);
    public bool CanAttackHeart();
}
