using UnityEngine;

public interface ICharacter
{
    
    public Vector3 GetPosition();
    public void Attack(ICharacter target);
    public void UnderAttack(ICharacter attacker);
}