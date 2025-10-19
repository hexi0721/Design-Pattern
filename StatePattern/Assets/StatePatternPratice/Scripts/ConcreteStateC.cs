using UnityEngine;

namespace Pratice
{
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context context) : base(context) { }

        public override void Handle(int value)
        {
            if (value > 30)
            {
                Debug.Log("狀態C handle -> 進入狀態A");
                context.SetState(new ConcreteStateA(context));
            }
        }
    }
    
}