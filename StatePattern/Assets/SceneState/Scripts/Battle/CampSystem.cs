using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampSystem : GameSystemBase
{
    private enum EnumEnemy
    {
        Elf,
    }

    public CampSystem(GameTestScript gameTest) : base(gameTest)
    {
        Init();
    }

    public void ShowCativeCamp()
    {
        // captiveCamps[EnumEnemy.Elf].SetVisible(true);
        gameTest.ShowMsg("獲得俘兵營");
    }
}
