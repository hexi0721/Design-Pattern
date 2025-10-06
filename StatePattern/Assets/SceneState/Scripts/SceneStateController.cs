using UnityEngine;
using UnityEngine.SceneManagement;

namespace StatePattern
{
    public class SceneStateController
    {
        private ISceneState state;
        private bool runBegin;
        private AsyncOperation loadingOperation;


        public void SetState(ISceneState state, string loadSceneName)
        {
            runBegin = false;

            loadingOperation = SceneManager.LoadSceneAsync(loadSceneName);
            
            this.state?.StateEnd();
            this.state = state;
        }

        public void StateUpdate()
        {
            
            if (!loadingOperation.isDone)
            {
                return;
            }

            if (state != null)
            {
                if (!runBegin)
                {
                    state.StateBegin();
                    runBegin = true;
                }

                state.StateUpdate();
            }
            
        }

    }

}