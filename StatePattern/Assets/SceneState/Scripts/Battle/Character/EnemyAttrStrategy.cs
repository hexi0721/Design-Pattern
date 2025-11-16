using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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