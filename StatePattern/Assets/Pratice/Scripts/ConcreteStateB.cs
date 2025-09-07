using UnityEngine;

namespace Pratice
{
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context context) : base(context) { }

        public override void Handle(int value)
        {
            if (value > 20)
            {
                Debug.Log("狀態B handle -> 進入狀態C");
                context.SetState(new ConcreteStateC(context));
            }
        }
    }

}