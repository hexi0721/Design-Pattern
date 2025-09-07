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
            Debug.Log("初始化...");
        }

        public void StateEnd()
        {
            Debug.Log("釋放...");
        }

        public void StateUpdate()
        {

            // InputProcess(); 玩家輸入

            // Game.Instance.Update(); // 遊戲邏輯

            // if (Game.Instance.IsGameOver())
            // {
            //     controller.SetState(new MainMenuState(controller), "MainMenuScene");
            // }
        }
        
    }
}