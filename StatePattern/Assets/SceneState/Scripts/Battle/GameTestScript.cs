using System;
using UnityEngine;

public class GameTestScript : MonoBehaviour
{

    private static GameTestScript instance;
    public static GameTestScript Instance
    {
        get
        {
            instance ??= new GameTestScript();
            return instance;
        }
    }

    private GameTestScript() {}
    private bool isGameOver;

    // private GameEventSystem gameEventSystem;
    // ...
    private CampSystem gameEventSystem;

    public void Init()
    {
        isGameOver = false;
        // gameEventSystem = new GameEventSystem(this);
        // ...
        gameEventSystem = new CampSystem(this);
    }

    public void SelfUpdate()
    {
        // gameEventSystem.Update();
        // ...
        gameEventSystem.SelfUpdate();
    }

    public bool CheckGameOver()
    {
        return isGameOver;
    }

    public void Release()
    {
        Debug.Log("Game釋放");
    }

    public void ShowMsg(string msg)
    {
        Debug.Log(msg);
    }
}
