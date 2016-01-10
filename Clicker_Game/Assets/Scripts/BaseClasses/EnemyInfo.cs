using System;
using UnityEngine;

[Serializable]
public class EnemyInfo 
{
    public string name;
    public int hp;
    public int maxHp;

    [SerializeField]
    public Loot[] lootTable = new Loot[1];

    public EnemyInfo()
    {
        name = "TestName";
        hp = 100;
        lootTable[0] = new Loot();
    }

}
