using UnityEngine;

namespace StatePattern
{

    public class StartState : ISceneState
    {
        private SceneStateController controller;

        public StartState(SceneStateController controller)
        {
            this.controller = controller;
        }

        public void StateBegin()
        {
            // 進行遊戲載入及初始設定等
            Debug.Log("StartState Begin");
        }

        public void StateEnd()
        {
            Debug.Log("StartState End");
        }

        public void StateUpdate()
        {
            controller.SetState(new MainMenuState(controller), "MainMenu");
        }

    }
}
