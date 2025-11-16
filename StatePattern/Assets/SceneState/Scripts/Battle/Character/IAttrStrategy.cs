using System;

public interface IAttrStrategy
{
    public void InitAttr(int level, Action<int> onAddMaxHp);
    public int TryGetAtkPlusValue(int maxHp, ref int critRate);
    public int GetDmgDescValue(int level);
    
}