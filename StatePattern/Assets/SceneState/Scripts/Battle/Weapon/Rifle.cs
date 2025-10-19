public class Rifle : Weapon
{
    private float lineWidth = 0.5f;
    private float displayTime = 0.2f;
    public override void Fire(ICharacter target)
    {
        ShowShootEffect();
        ShowBulletEffect(target.GetPosition(), lineWidth, displayTime);
        ShowSoundEffect("RifleShot");
    }

}