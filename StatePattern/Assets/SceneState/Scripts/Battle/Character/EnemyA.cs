using UnityEngine;

public class EnemyA : MonoBehaviour, IEnemy
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

    public void SetWeaponAtkPlusValue(int value)
    {
        
    }

    public void UnderAttack(ICharacter attacker)
    {
        
    }
}