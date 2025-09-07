namespace Pratice
{

    public abstract class State
    {
        protected Context context = null;
        public State(Context context)
        {
            this.context = context;
        }
        public abstract void Handle(int value);
    }
}