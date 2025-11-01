using System;
using UnityEngine;


public interface ICharacterAttr
{
    public int Hp { get; }
    public int MaxHp { get; }
    public float MoveSpeed { get; }
    public string AttrName { get; }
    public IAttrStrategy attrStrategy { get; set; }
    public void Init(int maxHp, float moveSpeed, string attrName);
    public void CalDmgValue(ICharacter attacker);
    public int GetAtkPlusValue();
    public void SetCritRate(int critRate);
}

public class SoldierAttr : ICharacterAttr
{

    public int Hp { get; private set; }
    public int MaxHp { get; private set; }
    public float MoveSpeed { get; private set; }
    public string AttrName { get; private set; }
    public int Level { get; set; }
    private int addMaxHp;
    public IAttrStrategy attrStrategy { get; set; }

    public void Init(int maxHp, float moveSpeed, string attrName)
    {
        Hp = maxHp;
        MaxHp = maxHp;
        MoveSpeed = moveSpeed;
        AttrName = attrName;
        attrStrategy.InitAttr(Level, OnAddMaxHp);
    }

    private void OnAddMaxHp(int 新增最大血量)
    {
        addMaxHp = 新增最大血量;
    }

    public int GetMaxHp() => MaxHp + addMaxHp;

    public void CalDmgValue(ICharacter attacker)
    {
        int damage = attacker.GetAtkValue() - attrStrategy.GetDmgDescValue(Level);
        Hp -= damage;
    }

    public int GetAtkPlusValue()
    {
        // 不用做
        return 0;
    }

    public void SetCritRate(int critRate)
    {
        // 不用做
    }
}

public class EnemyAttr : ICharacterAttr
{

    private int critRate;
    public int Hp { get; private set; }
    public int MaxHp { get; private set; }
    public float MoveSpeed { get; private set; }
    public string AttrName { get; private set; }
    public IAttrStrategy attrStrategy { get; set; }

    public void Init(int maxHp, float moveSpeed, string attrName)
    {
        Hp = maxHp;
        MaxHp = maxHp;
        MoveSpeed = moveSpeed;
        AttrName = attrName;
    }

    public void SetCritRate(int critRate)
    {
        this.critRate = critRate;
    }

    public int GetAtkPlusValue()
    {
        return attrStrategy.TryGetAtkPlusValue(MaxHp, ref critRate);
    }

    public void CalDmgValue(ICharacter attacker)
    {
        // 不用做
    }

}


public interface IAttrStrategy
{
    public void InitAttr(int level, Action<int> onAddMaxHp);
    public int TryGetAtkPlusValue(int maxHp, ref int critRate);
    public int GetDmgDescValue(int level);
    
}

public class SoldierAttrStrategy : IAttrStrategy
{
    public void InitAttr(int level, Action<int> onAddMaxHp)
    {
        int AddMaxHp = 0;
        if (level > 0)
        {
            AddMaxHp = (level - 1) * 2;
        }

        onAddMaxHp?.Invoke(AddMaxHp);
    }

    public int GetDmgDescValue(int level)
    {
        return (level - 1) * 2;
    }

    public int TryGetAtkPlusValue(int maxHp, ref int critRate)
    {
        // 不用做
        critRate = 0;
        return 0;
    }
}

public class EnemyAttrStrategy : IAttrStrategy
{

    private const int 倍率 = 5;

    public void InitAttr(int level, Action<int> onAddMaxHp)
    {
        // 不用做
    }
        
    public int GetDmgDescValue(int level)
    {
        // 不用做
        return 0;
    }

    public int TryGetAtkPlusValue(int maxHp, ref int critRate)
    {
        int randValue = UnityEngine.Random.Range(0, 100);
        if (critRate >= randValue)
        {
            critRate /= 2;
            return maxHp * 倍率;
        }

        return 0;
    }
}