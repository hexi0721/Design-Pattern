using System;
using System.Collections;
using System.Collections.Generic;
using Pratice;
using UnityEngine;
using UnityEngine.UI;


namespace StatePattern
{
    public class MainMenuState : ISceneState
    {
        private SceneStateController controller;
        public string StateName { get; set; }

        public MainMenuState(SceneStateController controller)
        {
            this.controller = controller;
            StateName = "MainMenuState";
        }

        public void StateBegin()
        {
            Button button = UITool.Instance.GetButton();

            if (button != null)
            {
                button.onClick.AddListener(OnStartGameBtnClick);
            }
            
        }

        private void OnStartGameBtnClick()
        {
            controller.SetState(new BattleState(controller) , "BattleState");
        }

        public void StateEnd()
        {

        }

        public void StateUpdate()
        {
            
        }
    }

}