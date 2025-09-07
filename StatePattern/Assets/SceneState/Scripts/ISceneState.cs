namespace StatePattern
{

    public interface ISceneState
    {
        public string StateName { get; set; }

        public void StateBegin();
        public void StateUpdate();
        public void StateEnd();
        public string ToString();

    }
}