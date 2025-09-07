namespace StatePattern
{

    public class StartState : ISceneState
    {
        private SceneStateController controller;
        public string StateName { get; set; }

        public StartState(SceneStateController controller)
        {
            this.controller = controller;
        }

        public void StateBegin()
        {
            // 進行遊戲載入及初始設定等
        }

        public void StateEnd()
        {
            
        }

        public void StateUpdate()
        {
            controller.SetState(new MainMenuState(controller), "MainMenuScene");
        }


    }
}
