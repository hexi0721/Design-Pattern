// Concrete = 具體的
using UnityEngine;

namespace Pratice
{

    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context context) : base(context) { }

        public override void Handle(int value)
        {
            if (value > 10)
            {
                Debug.Log("狀態A handle -> 進入狀態B");
                context.SetState(new ConcreteStateB(context));
            }
        }
    }
}