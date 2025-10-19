namespace Pratice
{

    public class Context
    {
        private State state = null;

        public void SetState(State state)
        {
            this.state = state;
        }

        public void Request(int value)
        {
            state.Handle(value);
        }

    }
}