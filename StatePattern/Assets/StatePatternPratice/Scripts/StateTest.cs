using UnityEngine;

namespace Pratice
{

    public class StateTest : MonoBehaviour
    {
        Context context = new Context();

        private void Start()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            context.SetState(new ConcreteStateA(context)); // 目前狀態A
            context.Request(5); // 仍在狀態A
            context.Request(15); // 進入狀態B
            context.Request(25); // 進入狀態C
            context.Request(35); // 進入狀態A
        }
    }
}