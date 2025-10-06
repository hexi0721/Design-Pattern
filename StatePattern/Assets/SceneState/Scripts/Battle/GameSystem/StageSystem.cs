using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSystem : IGameSystem
{


    private GameTestScript gameTest;
    public StageSystem(GameTestScript gameTest)
    {
        this.gameTest = gameTest;
        Init();
    }

    // private NowStageData nowStageData;
    private int nowStageLv;
    private int nowHeart;

    public void Init()
    {
        // gameTest.RegisterGameEvent(EnumGameEvent.EnemyKilled, new EnemyKilledObserverStageScore(this));
    }
    public void Release()
    {

    }
    public void SelfUpdate()
    {
        // nowStageData.SelfUpdate();

        // if (gameTest.GetEnemyCount() == 0)
        // {
        //     IStageHandler stageHandler = nowStageData.CheckStage();

        //     if (stageHandler != nowStageData)
        //     {
        //         nowStageData = stageHandler;
        //         NotifyNewStage();
        //     }
        // }
    }

    private void NotifyNewStage()
    {

        nowStageLv++;

        // gameTest.ShowNowStageLv(nowStageLv);
        gameTest.UpgradeSoldier();
        // gameTest.NotifyGameEvent(EnumGameEvent.NewStage, null);


    }

    public void LoseHeart()
    {
        nowHeart--;
        // gameTest.ShowHeart(nowHeart);
    }
}
