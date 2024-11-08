using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PokemonScriptSecond : ScriptableObject
{
    [SerializeField]
    private Sprite icon;

    public Sprite MyIcon
    {
        get
        {
            return icon;
        }
        set
        {
            icon = value;
        }
    }
    public BiomeList biomeFound;

    public BiomeList MyBiome
    {
        get
        {
            return biomeFound;
        }
        set
        {
            biomeFound = value;
        }
    }
    public PokemonRarity Rarity;

    public PokemonRarity rarity
    {
        get
        {
            return Rarity;
        }
        set
        {
            Rarity = value;
        }
    }
    public PokemonType Type;

    public PokemonType type
    {
        get
        {
            return Type;
        }
        set
        {
            Type = value;
        }
    }
    public PokemonName PokeName;

    public PokemonName pokename
    {
        get
        {
            return PokeName;
        }
        set
        {
            PokeName = value;
        }
    }

    public string Name;

    public string name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }

    public int Hp;

    public int hp
    {
        get
        {
            return Hp;
        }
        set
        {
            Hp = value;
        }
    }
    public int MaxHp;

    public int maxhp
    {
        get
        {
            return MaxHp;
        }
        set
        {
            MaxHp = value;
        }
    }
    public int Atack;

    public int atack
    {
        get
        {
            return Atack;
        }
        set
        {
            Atack = value;
        }
    }
    public int Deffensive;

    public int deffensive
    {
        get
        {
            return Deffensive;
        }
        set
        {
            Deffensive = value;
        }
    }
    public int Speed;

    public int speed
    {
        get
        {
            return Speed;
        }
        set
        {
            Speed = value;
        }
    }
    public int Level;

    public int level
    {
        get
        {
            return Level;
        }
        set
        {
            Level = value;
        }
    }


    public void AddMember(PokemonScriptSecond bp)
    {
        this.name = bp.name;
        this.MyIcon = bp.icon;
        this.type = bp.type;
        this.rarity = bp.rarity;
        this.hp = bp.hp;
        this.maxhp = bp.maxhp;
        this.speed = bp.speed;
        this.Atack = bp.Atack;
        this.deffensive = bp.deffensive;
        this.level = bp.level;
    }
}
public enum PokemonName
{
    FirstName
}

