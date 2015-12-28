using System;
using UnityEngine;

[Serializable]
public enum Rarity
{
    Trash,
    Common,
    Rare,
    Epic,
    Legendary,
    Unique
}

[Serializable]
public class Loot
{
    public GameObject lootObject;
    public string lootName;
    public int lootWorth;
    
    [SerializeField]
    public Rarity lootRarity;
}
