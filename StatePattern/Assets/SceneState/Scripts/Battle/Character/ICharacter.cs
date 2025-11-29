using UnityEngine;
using System.Collections.Generic;

public interface ICharacter
{
    public string Name { get; }
    public bool IsKilled { get; }

    public Vector3 GetPosition();
    public void Attack(ICharacter target);
    public void UnderAttack(ICharacter attacker);
    public int GetAtkValue();
    public float GetAtkRange();

    public void SetAI(ICharacterAI ai);
    public void UpdateAI(List<ICharacter> targets);
    public void RemoveAITarget(ICharacter ai);
    
    public void Killed();
    public void MoveTo(Vector3 pos);
    public void StopMove();
}