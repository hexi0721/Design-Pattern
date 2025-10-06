using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampInfoUI : MonoBehaviour , IUserInterface
{
    private GameTestScript gameTestScript;

    public CampInfoUI(GameTestScript gameTestScript)
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

    internal void Hide()
    {
        throw new NotImplementedException();
    }

    internal void ShowInfo(ICamp camp)
    {
        throw new NotImplementedException();
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
