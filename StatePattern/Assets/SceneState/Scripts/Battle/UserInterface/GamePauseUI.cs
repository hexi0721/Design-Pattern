using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseUI : MonoBehaviour, IUserInterface
{

    private GameTestScript gameTestScript;

    public GamePauseUI(GameTestScript gameTestScript)
    {
        this.gameTestScript = gameTestScript;
    }

    public void Init()
    {
        throw new System.NotImplementedException();
    }

    public void Release()
    {
        throw new System.NotImplementedException();
    }

    public void SelfUpdate()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
