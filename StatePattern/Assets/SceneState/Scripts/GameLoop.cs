using UnityEngine;

namespace StatePattern
{

    public class GameLoop : MonoBehaviour
    {
        SceneStateController controller = new SceneStateController();

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            controller.SetState(new StartState(controller), "Start");
        }

        private void Update()
        {
            controller.StateUpdate();
        }
    }

}