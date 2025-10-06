using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApSystem : MonoBehaviour
{
    private GameTestScript gameTest;
    public ApSystem(GameTestScript gameTest)
    {
        this.gameTest = gameTest;
    }

    public void Init() { }
    public void Release() { }
    public void SelfUpdate() { }
}
