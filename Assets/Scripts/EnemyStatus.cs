using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyStatus : ScriptableObject
{
    [SerializeField]
    public string characterName = "";
    [SerializeField]
    public int maxHp = 100;
    [SerializeField]
    public int hp = 100;
    [SerializeField]
    public int attack;

    public void SetCharacterName(string characterName)
    {
        this.characterName = characterName;
    }

    public string GetCharacterName()
    {
        return characterName;
    }
    public void SetMaxHp(int hp)
    {
        this.maxHp = hp;
    }

    public int GetMaxHp()
    {
        return maxHp;
    }

    public void SetHp(int hp)
    {
        this.hp = Mathf.Max(0, Mathf.Min(GetMaxHp(), hp));
    }

    public int GetHp()
    {
        return hp;
    }
    public void SetAttack(int attack)
    {
        this.attack = attack;
    }

    public int GetAttack()
    {
        return attack;
    }
}
