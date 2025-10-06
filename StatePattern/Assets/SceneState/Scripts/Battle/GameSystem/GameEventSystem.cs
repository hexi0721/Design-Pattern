using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventSystem : MonoBehaviour, IGameSystem
{

    private GameTestScript gameTest;
    public GameEventSystem(GameTestScript gameTest)
    {
        this.gameTest = gameTest;
    }

    public void Init() { }
    public void Release() { }
    public void SelfUpdate() { }

}
