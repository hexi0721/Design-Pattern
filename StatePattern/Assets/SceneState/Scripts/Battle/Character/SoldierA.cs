using UnityEngine;

public class SoldierA : MonoBehaviour, ISoldier
{
    private Weapon weapon;
    public Weapon Weapon
    {
        get => weapon;
        set
        {
            if (weapon != null)
            {
                weapon.Release();
            }

            weapon = value;
        }
    }

    public void Attack(ICharacter target)
    {
        weapon.Fire(target);
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void UnderAttack(ICharacter attacker)
    {
        
    }
}