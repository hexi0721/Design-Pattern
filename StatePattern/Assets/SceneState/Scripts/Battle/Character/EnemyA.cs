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

    private ICharacterAttr attribute;

    public void Init()
    {
        attribute = new EnemyAttr();
        attribute.Init(100, 1, "敵方士兵");
        attribute.SetCritRate(20);
    }

    public void Attack(ICharacter target)
    {
        weapon.SetAtkPlusValue(attribute.GetAtkPlusValue());
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
    
    public int GetAtkValue()
    {
        return weapon.GetAtkValue();
    }
}