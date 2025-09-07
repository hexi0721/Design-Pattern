using UnityEngine;
using UnityEngine.SceneManagement;

namespace StatePattern
{
    public class SceneStateController
    {
        private ISceneState state;
        private bool runBegin;
        AsyncOperation loadingOperation;
        private string loadSceneName;

        public void SetState(ISceneState state, string loadSceneName)
        {
            runBegin = false;
            this.loadSceneName = loadSceneName;

            SceneManager.LoadScene(loadSceneName);

            if (state != null)
            {
                state.StateEnd();
            }

            this.state = state;
        }

        public void StateUpdate()
        {
            loadingOperation = SceneManager.LoadSceneAsync(loadSceneName);

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