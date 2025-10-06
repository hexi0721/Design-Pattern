using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampSystem : MonoBehaviour, IGameSystem
{
    private GameTestScript gameTest;



    public CampSystem(GameTestScript gameTest)
    {

    }

    public void ShowCativeCamp()
    {
        // captiveCamps[EnumEnemy.Elf].SetVisible(true);
        gameTest.ShowMsg("獲得俘兵營");
    }

    public void Init()
    {

    }

    public void Release()
    { 

    }
    
    public void SelfUpdate()
    {

    }
}
