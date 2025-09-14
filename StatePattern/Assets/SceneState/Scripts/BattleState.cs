using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{

    public class BattleState : ISceneState
    {

        private SceneStateController controller;
        public string StateName { get; set; }

        public BattleState(SceneStateController controller)
        {
            this.controller = controller;
            StateName = "BattelState";
        }

        public void StateBegin()
        {
            Debug.Log("BattelState 初始化...");
            GameTestScript.Instance.Init();
        }

        public void StateEnd()
        {
            Debug.Log("BattelState 釋放...");
            GameTestScript.Instance.Release();
        }

        public void StateUpdate()
        {
            Debug.Log("BattelState 執行邏輯...");
            // InputProcess(); 玩家輸入

            GameTestScript.Instance.SelfUpdate();

            if (GameTestScript.Instance.CheckGameOver())
            {
                controller.SetState(new MainMenuState(controller), "MainMenuScene");
            }
        }
        
    }
}