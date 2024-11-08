using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFighter : MonoBehaviour
{

    public string Name;
    public Sprite Image;
    public BiomeList biomeFound;
    public FighterType type;
    public Rarity rarity;
    public int HP;
    private int maxHP;
    public int speed;
    public int Atack;
    public int Deffense;

    private int level;

    public void AddMember(BaseFighter bp)
    {
        this.Name = bp.Name;
        this.Image = bp.Image;
        this.biomeFound = bp.biomeFound;
        this.type = bp.type;
        this.rarity = bp.rarity;
        this.HP = bp.HP;
        this.maxHP = bp.maxHP;
        this.speed = bp.speed;
        this.Atack = bp.Atack;
        this.Deffense = bp.Deffense;
        this.level = bp.level;
    }
}

public enum Rarity
{
    VeryCommon,
    Common,
    SemiRare,
    Rare,
    VeryRare,
    Legendary
}
public enum FighterType
{
    Fire,
    Water,
    Grass,
}

