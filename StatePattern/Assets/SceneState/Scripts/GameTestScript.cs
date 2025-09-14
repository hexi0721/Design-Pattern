using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameTestScript : MonoBehaviour
{


    public static GameTestScript Instance { get; private set; }
    private bool isGameOver;

    // private GameEventSystem gameEventSystem;
    // ...

    public GameTestScript()
    {
        Instance = this;
    }

    public void Init()
    {
        isGameOver = false;
        // gameEventSystem = new GameEventSystem(this);
        // ...
    }

    public void SelfUpdate()
    {
        // gameEventSystem.Update();
        // ...

        Debug.Log(1);
    }

    public bool CheckGameOver()
    {
        return isGameOver;
    }

    public void Release()
    {
        Debug.Log("Game釋放");
    }
}
