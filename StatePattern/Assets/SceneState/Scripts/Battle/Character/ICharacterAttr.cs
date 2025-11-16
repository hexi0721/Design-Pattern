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