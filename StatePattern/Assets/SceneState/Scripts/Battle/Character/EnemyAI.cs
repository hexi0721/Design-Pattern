using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAI : ICharacterAI
{
    private static StageSystem stageSystem;
    private ICharacter character;
    private float atkRange;
    private AIStateBase ai;
    private Vector3 atkPos;

    private float coolDown = AtkCoolDown;
    private const float AtkCoolDown = 1f;


    public static void SetStageSystem(StageSystem stageSystem)
    {
        EnemyAI.stageSystem = stageSystem;
    }

    public void Init(ICharacter character, Vector3 atkPos)
    {
        this.character = character;
        atkRange = character.GetAtkRange();
        ChangeAIState(new IdleAIState());
        this.atkPos = atkPos;
    }

    public void Attack(ICharacter target)
    {
        coolDown -= Time.deltaTime;
        if(coolDown > 0)
        {
            return;
        }
        coolDown = AtkCoolDown;
        character.Attack(target);
    }

    public bool CanAttackHeart()
    {
        stageSystem.LoseHeart();
        return true;
    }

    public void ChangeAIState(AIStateBase ai)
    {
        this.ai = ai;
        ai.SetCharacterAI(this);
        ai.SetAttackPos(atkPos);
    }

    public Vector3 GetPos()
    {
        return character.GetPosition();
    }

    public bool IsKilled()
    {
        return character.IsKilled;
    }

    public bool IsTargetInAtkRange(ICharacter target)
    {
        float dist = Vector3.Distance(target.GetPosition(), character.GetPosition());
        return dist <= atkRange;
    }

    public void Killed()
    {
        character.Killed();
    }

    public void MoveTo(Vector3 pos)
    {
        character.MoveTo(pos);
    }

    public void RemoveAITarget(ICharacter target)
    {
        ai.RemoveTarget(target);
    }

    public void SelfUpdate(List<ICharacter> targets)
    {
        ai.SelfUpdate(targets);
    }

    public void StopMove()
    {
        character.StopMove();
    }
}
