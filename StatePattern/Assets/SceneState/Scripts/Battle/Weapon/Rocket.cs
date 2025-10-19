public class Rocket : Weapon
{
    private float lineWidth = 0.8f;
    private float displayTime = 0.5f;
    public override void Fire(ICharacter target)
    {
        ShowShootEffect();
        ShowBulletEffect(target.GetPosition(), lineWidth, displayTime);
        ShowSoundEffect("RocketShot");
    }

}