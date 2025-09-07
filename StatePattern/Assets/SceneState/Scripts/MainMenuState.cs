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
            Debug.Log("MainMenuState Begin");
            Button button = UITool.GetButton();

            if (button != null)
            {
                button.onClick.AddListener(OnStartGameBtnClick);
            }
        }

        private void OnStartGameBtnClick()
        {
            controller.SetState(new BattleState(controller) , "Battle");
        }

        public void StateEnd()
        {
            Debug.Log("MainMenuState End");
        }

        public void StateUpdate()
        {
            Debug.Log("MainMenuState 等待按下開始按鈕");
        }
    }

}