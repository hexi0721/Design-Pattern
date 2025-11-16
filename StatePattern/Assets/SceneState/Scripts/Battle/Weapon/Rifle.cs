public class Rifle : Weapon
{
    private float lineWidth = 0.5f;
    private float displayTime = 0.2f;

    protected override void DoShowBulletEffect(ICharacter target)
    {
        ShowBulletEffect(target.GetPosition(), lineWidth, displayTime);
    }

    protected override void DoShowSoundEffect()
    {
        ShowSoundEffect("RifleShot");
    }

}