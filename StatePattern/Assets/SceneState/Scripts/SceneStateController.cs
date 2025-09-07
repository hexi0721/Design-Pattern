using UnityEngine;
using UnityEngine.SceneManagement;

namespace StatePattern
{
    public class SceneStateController
    {
        private ISceneState state;
        private bool runBegin;
        AsyncOperation loadingOperation;


        public void SetState(ISceneState state, string loadSceneName)
        {
            runBegin = false;

            loadingOperation = SceneManager.LoadSceneAsync(loadSceneName);

            if (this.state != null)
            {
                this.state.StateEnd();
            }

            this.state = state;
        }

        public void StateUpdate()
        {
            
            if (!loadingOperation.isDone)
            {
                return;
            }

            if (state != null && runBegin == false)
            {
                state.StateBegin();
                runBegin = true;
            }

            if (state != null)
            {
                state.StateUpdate();
            }
            
        }

    }

}