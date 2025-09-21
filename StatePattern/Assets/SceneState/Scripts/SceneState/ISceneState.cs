namespace StatePattern
{

    public interface ISceneState
    {
        public void StateBegin();
        public void StateUpdate();
        public void StateEnd();

    }
}