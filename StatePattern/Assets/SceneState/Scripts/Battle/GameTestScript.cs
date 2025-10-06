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

    private GameTestScript() { }
    private bool isGameOver;


    private GameEventSystem gameEventSystem;
    private CampSystem campSystem;
    private StageSystem stageSystem;
    private CharacterSystem characterSystem;
    private ApSystem apSystem;
    private AchievementSystem achievementSystem;


    private CampInfoUI campInfoUI;
    private SoldierInfoUI soldierInfoUI;
    private GameStateInfoUI gameStateInfoUI;
    private GamePauseUI gamePauseUI;

    public void Init()
    {
        isGameOver = false;
        gameEventSystem = new GameEventSystem(this);
        campSystem = new CampSystem(this);
        stageSystem = new StageSystem(this);
        characterSystem = new CharacterSystem(this);
        apSystem = new ApSystem(this);
        achievementSystem = new AchievementSystem(this);

        campInfoUI = new CampInfoUI(this);
        soldierInfoUI = new SoldierInfoUI(this);
        gameStateInfoUI = new GameStateInfoUI(this);
        gamePauseUI = new GamePauseUI(this);
    }

    public void SelfUpdate()
    {
        gameEventSystem.SelfUpdate();
        campSystem.SelfUpdate();
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

    public void UpgradeSoldier()
    {
        if (characterSystem != null)
        {
            characterSystem.UpgradeSoldier();
        }
    }

    public void AddSoldier(ISoldier soldier)
    {
        if (characterSystem != null)
        {
            characterSystem.AddSoldier(soldier);
        }
    }

    public void RemoveSoldier(ISoldier soldier)
    {
        if (characterSystem != null)
        {
            characterSystem.RemoveSoldier(soldier);
        }
    }

    public void AddEnemy(IEnemy enemy)
    {
        if (characterSystem != null)
        {
            characterSystem.AddEnemy(enemy);
        }
    }

    public void RemoveEnemy(IEnemy enemy)
    {
        if (characterSystem != null)
        {
            characterSystem.RemoveEnemy(enemy);
        }
    }

    public void ShowCampInfo(ICamp camp)
    {
        campInfoUI.ShowInfo(camp);
        soldierInfoUI.Hide();
    }

    public void ShowSoldierInfo(ISoldier soldier)
    {
        campInfoUI.Hide();
        soldierInfoUI.ShowInfo(soldier);
    }

    // public void RegisterGameEvent(EnumGameEvent enumGameEvent, IGameEventObserver observer)
    // {
    //     gameEventSystem.RegisterObserver(enumGameEvent, observer);
    // }

    // public void NotifyGameEvent(EnumGameEvent enumGameEvent, Object param)
    // {
    //     gameEventSystem.NotifySubject(enumGameEvent, param);
    // }
    

}

public interface IEnemy
{

}

public interface ISoldier
{

}

public interface ICamp
{
    
}