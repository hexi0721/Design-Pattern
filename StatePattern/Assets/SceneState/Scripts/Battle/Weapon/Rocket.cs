public class Rocket : Weapon
{
    private float lineWidth = 0.8f;
    private float displayTime = 0.5f;

    protected override void DoShowBulletEffect(ICharacter target)
    {
        ShowBulletEffect(target.GetPosition(), lineWidth, displayTime);
    }

    protected override void DoShowSoundEffect()
    {
        ShowSoundEffect("RocketShot");
    }

}