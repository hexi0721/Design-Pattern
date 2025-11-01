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

    private ICharacterAttr attribute;

    public void Init()
    {
        attribute = new SoldierAttr();
        attribute.Init(100 , 1, "普通士兵");
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
        attribute.CalDmgValue(attacker);

        if(attribute.Hp <= 0)
        {
            Debug.Log("角色陣亡");
        }
    }
    
    public int GetAtkValue()
    {
        return weapon.GetAtkValue();
    }
}