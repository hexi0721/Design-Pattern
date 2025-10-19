public class Gun : Weapon
{
    private float lineWidth = 0.03f;
    private float displayTime = 0.2f;
    public override void Fire(ICharacter target)
    {
        ShowShootEffect();
        ShowBulletEffect(target.GetPosition(), lineWidth, displayTime);
        ShowSoundEffect("GunShot");
    }

}