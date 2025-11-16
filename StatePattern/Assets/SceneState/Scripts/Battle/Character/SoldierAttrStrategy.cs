using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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