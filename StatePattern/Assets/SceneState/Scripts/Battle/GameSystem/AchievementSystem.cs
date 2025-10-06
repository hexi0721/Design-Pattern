using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : MonoBehaviour
{
    private GameTestScript gameTest;
    public AchievementSystem(GameTestScript gameTest)
    {
        this.gameTest = gameTest;
    }

    public void Init() { }
    public void Release() { }
    public void SelfUpdate() { }
}
