using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSystem : MonoBehaviour
{
    private GameTestScript gameTest;
    public CharacterSystem(GameTestScript gameTest)
    {
        this.gameTest = gameTest;
    }

    public void Init() { }
    public void Release() { }
    public void SelfUpdate() { }

    public void UpgradeSoldier()
    {
        
    }

    internal void AddEnemy(IEnemy enemy)
    {
        throw new NotImplementedException();
    }

    internal void AddSoldier(ISoldier soldier)
    {
        throw new NotImplementedException();
    }

    internal void RemoveEnemy(IEnemy enemy)
    {
        throw new NotImplementedException();
    }

    internal void RemoveSoldier(ISoldier soldier)
    {
        throw new NotImplementedException();
    }
}
