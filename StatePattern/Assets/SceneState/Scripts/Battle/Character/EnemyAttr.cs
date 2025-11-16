using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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