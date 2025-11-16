using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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