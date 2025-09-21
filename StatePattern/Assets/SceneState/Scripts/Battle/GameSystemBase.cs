using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameSystemBase
{
    protected GameTestScript gameTest = null;

    public GameSystemBase(GameTestScript gameTest)
    {
        this.gameTest = gameTest;
    }

    public virtual void Init() { }
    public virtual void Release() { }
    public virtual void SelfUpdate() { }
    
}
