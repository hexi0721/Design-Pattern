using System;
using UnityEngine;

public abstract class Weapon
{

    protected int atkPlusValue = 1;
    protected int atk;
    protected float range;

    protected GameObject go;
    protected ICharacter weaponOwner;

    protected float effectDisplayTime;
    protected ParticleSystem ps;
    protected LineRenderer lineRenderer;
    protected AudioSource audio;
    protected Light light;

    protected void ShowBulletEffect(Vector3 targetPostion, float lineWidth, float displayTime)
    {
        if (lineRenderer == null)
        {
            return;
        }

        lineRenderer.enabled = true;
        lineRenderer.startWidth = lineWidth;
        lineRenderer.SetPosition(0, go.transform.position);
        lineRenderer.SetPosition(1, targetPostion);
        effectDisplayTime = displayTime;
    }

    protected void ShowShootEffect()
    {
        if (ps != null)
        {
            ps.Stop();
            ps.Play();
        }

        if (light != null)
        {
            lineRenderer.enabled = true;
        }
    }

    protected void ShowSoundEffect(string clipName)
    {
        if (audio == null)
        {
            return;
        }

        // 取得音效
        // IAssetFactory factory = PBDFactory.GetAssetFactory();
        // AudioClip audioClip = factory.LoadAudioClip(ClipName);
        // if (audioClip == null)
        // {
        //     return;
        // }

        // audio.clip = audioClip;
        audio.Play();
    }

    public abstract void Fire(ICharacter target);

    public void Release()
    {

    }
    
    public int GetAtkValue()
    {
        return atk * atkPlusValue;
    }

    public void SetAtkPlusValue(int atkPlusValue)
    {
        this.atkPlusValue = atkPlusValue;
    }
}
