using System.Collections.Generic;
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

    public string Name {get; private set;}

    public bool IsKilled { get; private set;}

    private ICharacterAttr attribute;
    private ICharacterAI ai;

    public void Init()
    {
        attribute = new EnemyAttr();
        attribute.Init(100, 1, "敵方士兵");
        attribute.SetCritRate(20);
        Name = attribute.AttrName;
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
        attribute.CalDmgValue(attacker);

        if(attribute.Hp <= 0)
        {
            Debug.Log("角色陣亡");
            IsKilled = true;
        }
    }
    
    public int GetAtkValue()
    {
        return weapon.GetAtkValue();
    }

    public float GetAtkRange()
    {
        return 0;
    }

    public void SetAI(ICharacterAI ai)
    {
        this.ai = ai;
    }

    public void UpdateAI(List<ICharacter> targets)
    {
        ai.SelfUpdate(targets);
    }
    public void RemoveAITarget(ICharacter target)
    {
        ai.RemoveAITarget(target);
    }

    public void Killed()
    {
        
    }

    public void MoveTo(Vector3 pos)
    {
        
    }

    public void StopMove()
    {
        
    }
}