using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PokemonData
{
    public string Name;

    //public Sprite icon;
    public int Iconint;
    public int Spriteint;

    //public PokemonType type;
    public int TypeInt;

    public int StatusInt;

    //public PokemonRarity rarity;
    public int RarityInt;

    public int HP;
    public int maxHP;
    //public Stat AttackStat;
    public int AtackMinInt;
    public int AtackMaxInt;

    //public Stat DefenceStat;
    public int DefenseMinInt;
    public int DefenseMaxInt;

    //public PokemonStats pokemonStats;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;

    public int MaxHpInt;
    public int HpInt;


    public bool canEvolve;
    //public PokemonEvolution evolveTo;
    public int EvolveToInt;
    public int LevelToEvolveInt;

    //public LevelUp LevelUp;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpeedRiseInt;

    public int level;


    //public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;
    

    //public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();

    public PokemonData (PokemonScript Pokemon)
    {
        Name = Pokemon.Name;
        //icon = Pokemon.icon;
        //type = Pokemon.type;
        //rarity = Pokemon.rarity;
        HP = Pokemon.HP;
        maxHP = Pokemon.maxHP;
        //AttackStat = Pokemon.AttackStat;
       // DefenceStat = Pokemon.DefenceStat;
       // pokemonStats = Pokemon.pokemonStats;
       // canEvolve = Pokemon.canEvolve;
        //evolveTo = Pokemon.evolveTo;
        level = Pokemon.level;
        //LevelUp = Pokemon.LevelUp;
        /*MovesICanUse[0] = Pokemon.MovesICanUse[0];
        MovesICanUse[1] = Pokemon.MovesICanUse[1];
        MovesICanUse[2] = Pokemon.MovesICanUse[2];
        MovesICanUse[3] = Pokemon.MovesICanUse[3];*/

        MovesICanUse1Int = Pokemon.MovesICanUse1Int;
        MovesICanUse2Int = Pokemon.MovesICanUse2Int;
        MovesICanUse3Int = Pokemon.MovesICanUse3Int;
        MovesICanUse4Int = Pokemon.MovesICanUse4Int;
        AmountOfHpRiseInt = Pokemon.AmountOfHpRiseInt;
        AmountOfAtackRiseInt = Pokemon.AmountOfAtackRiseInt;
        AmountOfDeffRiseInt = Pokemon.AmountOfDeffRiseInt;
        AmountOfSpeedRiseInt = Pokemon.AmountOfSpeedRiseInt;
        EvolveToInt = Pokemon.EvolveToInt;
        AttackStatInt = Pokemon.AttackStatInt;
        DefenceStatInt = Pokemon.DefenceStatInt;
        SpeedStatInt = Pokemon.SpeedStatInt;
        DefenseMinInt = Pokemon.DefenseMinInt;
        DefenseMaxInt = Pokemon.DefenseMaxInt;
        AtackMinInt = Pokemon.AtackMinInt;
        AtackMaxInt = Pokemon.AtackMaxInt;
        RarityInt = Pokemon.RarityInt;
        Iconint = Pokemon.Iconint;
        Spriteint = Pokemon.Spriteint;
        TypeInt = Pokemon.TypeInt;
        LevelToEvolveInt = Pokemon.LevelToEvolveInt;
        StatusInt = Pokemon.StatusInt;
        MaxHpInt = Pokemon.MaxHpInt;
        HpInt = Pokemon.HpInt;

    }

}

[System.Serializable]
public class Pokemon2Data
{
    public string Name;

    //public Sprite icon;
    public int Iconint;
    public int Spriteint;

    //public PokemonType type;
    public int TypeInt;
    public int StatusInt;

    //public PokemonRarity rarity;
    public int RarityInt;

    public int HP;
    public int maxHP;
    //public Stat AttackStat;
    public int AtackMinInt;
    public int AtackMaxInt;

    //public Stat DefenceStat;
    public int DefenseMinInt;
    public int DefenseMaxInt;

    public int Move1PP;
    public int Move2PP;
    public int Move3PP;
    public int Move4PP;

    //public PokemonStats pokemonStats;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;
    public int SpAttackStatInt;
    public int SpDefenceStatInt;

    public int MaxHpInt;
    public int HpInt;


    public bool canEvolve;
    //public PokemonEvolution evolveTo;
    public int EvolveToInt;
    public int LevelToEvolveInt;

    //public LevelUp LevelUp;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpAtackpRiseInt;
    public int AmountOfSpDeffRiseInt;
    public int AmountOfSpeedRiseInt;

    public int level;


    //public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;

    //public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();

    public Pokemon2Data(PokemonScript Pokemon)
    {
        Name = Pokemon.Name;
        //icon = Pokemon.icon;
        //type = Pokemon.type;
        //rarity = Pokemon.rarity;
        HP = Pokemon.HP;
        maxHP = Pokemon.maxHP;
        //AttackStat = Pokemon.AttackStat;
        // DefenceStat = Pokemon.DefenceStat;
        // pokemonStats = Pokemon.pokemonStats;
        // canEvolve = Pokemon.canEvolve;
        //evolveTo = Pokemon.evolveTo;
        level = Pokemon.level;
        //LevelUp = Pokemon.LevelUp;
        /*MovesICanUse[0] = Pokemon.MovesICanUse[0];
        MovesICanUse[1] = Pokemon.MovesICanUse[1];
        MovesICanUse[2] = Pokemon.MovesICanUse[2];
        MovesICanUse[3] = Pokemon.MovesICanUse[3];*/

        MovesICanUse1Int = Pokemon.MovesICanUse1Int;
        MovesICanUse2Int = Pokemon.MovesICanUse2Int;
        MovesICanUse3Int = Pokemon.MovesICanUse3Int;
        MovesICanUse4Int = Pokemon.MovesICanUse4Int;
        AmountOfHpRiseInt = Pokemon.AmountOfHpRiseInt;
        AmountOfAtackRiseInt = Pokemon.AmountOfAtackRiseInt;
        AmountOfDeffRiseInt = Pokemon.AmountOfDeffRiseInt;
        AmountOfSpeedRiseInt = Pokemon.AmountOfSpeedRiseInt;
        EvolveToInt = Pokemon.EvolveToInt;
        AttackStatInt = Pokemon.AttackStatInt;
        DefenceStatInt = Pokemon.DefenceStatInt;
        SpeedStatInt = Pokemon.SpeedStatInt;
        DefenseMinInt = Pokemon.DefenseMinInt;
        DefenseMaxInt = Pokemon.DefenseMaxInt;
        AtackMinInt = Pokemon.AtackMinInt;
        AtackMaxInt = Pokemon.AtackMaxInt;
        RarityInt = Pokemon.RarityInt;
        Iconint = Pokemon.Iconint;
        Spriteint = Pokemon.Spriteint;
        TypeInt = Pokemon.TypeInt;
        LevelToEvolveInt = Pokemon.LevelToEvolveInt;
        StatusInt = Pokemon.StatusInt;
        MaxHpInt = Pokemon.MaxHpInt;
        HpInt = Pokemon.HpInt;
    }

}

[System.Serializable]
public class Pokemon3Data
{
    public string Name;

    //public Sprite icon;
    public int Iconint;
    public int Spriteint;

    //public PokemonType type;
    public int TypeInt;
    public int StatusInt;

    //public PokemonRarity rarity;
    public int RarityInt;

    public int HP;
    public int maxHP;
    //public Stat AttackStat;
    public int AtackMinInt;
    public int AtackMaxInt;

    //public Stat DefenceStat;
    public int DefenseMinInt;
    public int DefenseMaxInt;

    public int Move1PP;
    public int Move2PP;
    public int Move3PP;
    public int Move4PP;

    //public PokemonStats pokemonStats;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;
    public int SpAttackStatInt;
    public int SpDefenceStatInt;

    public int MaxHpInt;
    public int HpInt;


    public bool canEvolve;
    //public PokemonEvolution evolveTo;
    public int EvolveToInt;
    public int LevelToEvolveInt;

    //public LevelUp LevelUp;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpAtackpRiseInt;
    public int AmountOfSpDeffRiseInt;
    public int AmountOfSpeedRiseInt;

    public int level;


    //public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;

    //public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();

    public Pokemon3Data(PokemonScript Pokemon)
    {
        Name = Pokemon.Name;
        //icon = Pokemon.icon;
        //type = Pokemon.type;
        //rarity = Pokemon.rarity;
        HP = Pokemon.HP;
        maxHP = Pokemon.maxHP;
        //AttackStat = Pokemon.AttackStat;
        // DefenceStat = Pokemon.DefenceStat;
        // pokemonStats = Pokemon.pokemonStats;
        // canEvolve = Pokemon.canEvolve;
        //evolveTo = Pokemon.evolveTo;
        level = Pokemon.level;
        //LevelUp = Pokemon.LevelUp;
        /*MovesICanUse[0] = Pokemon.MovesICanUse[0];
        MovesICanUse[1] = Pokemon.MovesICanUse[1];
        MovesICanUse[2] = Pokemon.MovesICanUse[2];
        MovesICanUse[3] = Pokemon.MovesICanUse[3];*/

        MovesICanUse1Int = Pokemon.MovesICanUse1Int;
        MovesICanUse2Int = Pokemon.MovesICanUse2Int;
        MovesICanUse3Int = Pokemon.MovesICanUse3Int;
        MovesICanUse4Int = Pokemon.MovesICanUse4Int;
        AmountOfHpRiseInt = Pokemon.AmountOfHpRiseInt;
        AmountOfAtackRiseInt = Pokemon.AmountOfAtackRiseInt;
        AmountOfDeffRiseInt = Pokemon.AmountOfDeffRiseInt;
        AmountOfSpeedRiseInt = Pokemon.AmountOfSpeedRiseInt;
        EvolveToInt = Pokemon.EvolveToInt;
        AttackStatInt = Pokemon.AttackStatInt;
        DefenceStatInt = Pokemon.DefenceStatInt;
        SpeedStatInt = Pokemon.SpeedStatInt;
        DefenseMinInt = Pokemon.DefenseMinInt;
        DefenseMaxInt = Pokemon.DefenseMaxInt;
        AtackMinInt = Pokemon.AtackMinInt;
        AtackMaxInt = Pokemon.AtackMaxInt;
        RarityInt = Pokemon.RarityInt;
        Iconint = Pokemon.Iconint;
        Spriteint = Pokemon.Spriteint;
        TypeInt = Pokemon.TypeInt;
        LevelToEvolveInt = Pokemon.LevelToEvolveInt;
        StatusInt = Pokemon.StatusInt;
        MaxHpInt = Pokemon.MaxHpInt;
        HpInt = Pokemon.HpInt;
    }

}

[System.Serializable]
public class Pokemon4Data
{
    public string Name;

    //public Sprite icon;
    public int Iconint;
    public int Spriteint;

    //public PokemonType type;
    public int TypeInt;
    public int StatusInt;

    //public PokemonRarity rarity;
    public int RarityInt;

    public int HP;
    public int maxHP;
    //public Stat AttackStat;
    public int AtackMinInt;
    public int AtackMaxInt;

    //public Stat DefenceStat;
    public int DefenseMinInt;
    public int DefenseMaxInt;

    public int Move1PP;
    public int Move2PP;
    public int Move3PP;
    public int Move4PP;

    //public PokemonStats pokemonStats;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;
    public int SpAttackStatInt;
    public int SpDefenceStatInt;

    public int MaxHpInt;
    public int HpInt;


    public bool canEvolve;
    //public PokemonEvolution evolveTo;
    public int EvolveToInt;
    public int LevelToEvolveInt;

    //public LevelUp LevelUp;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpAtackpRiseInt;
    public int AmountOfSpDeffRiseInt;
    public int AmountOfSpeedRiseInt;


    public int level;


    //public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;

    //public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();

    public Pokemon4Data(PokemonScript Pokemon)
    {
        Name = Pokemon.Name;
        //icon = Pokemon.icon;
        //type = Pokemon.type;
        //rarity = Pokemon.rarity;
        HP = Pokemon.HP;
        maxHP = Pokemon.maxHP;
        //AttackStat = Pokemon.AttackStat;
        // DefenceStat = Pokemon.DefenceStat;
        // pokemonStats = Pokemon.pokemonStats;
        // canEvolve = Pokemon.canEvolve;
        //evolveTo = Pokemon.evolveTo;
        level = Pokemon.level;
        //LevelUp = Pokemon.LevelUp;
        /*MovesICanUse[0] = Pokemon.MovesICanUse[0];
        MovesICanUse[1] = Pokemon.MovesICanUse[1];
        MovesICanUse[2] = Pokemon.MovesICanUse[2];
        MovesICanUse[3] = Pokemon.MovesICanUse[3];*/

        MovesICanUse1Int = Pokemon.MovesICanUse1Int;
        MovesICanUse2Int = Pokemon.MovesICanUse2Int;
        MovesICanUse3Int = Pokemon.MovesICanUse3Int;
        MovesICanUse4Int = Pokemon.MovesICanUse4Int;
        AmountOfHpRiseInt = Pokemon.AmountOfHpRiseInt;
        AmountOfAtackRiseInt = Pokemon.AmountOfAtackRiseInt;
        AmountOfDeffRiseInt = Pokemon.AmountOfDeffRiseInt;
        AmountOfSpeedRiseInt = Pokemon.AmountOfSpeedRiseInt;
        EvolveToInt = Pokemon.EvolveToInt;
        AttackStatInt = Pokemon.AttackStatInt;
        DefenceStatInt = Pokemon.DefenceStatInt;
        SpeedStatInt = Pokemon.SpeedStatInt;
        DefenseMinInt = Pokemon.DefenseMinInt;
        DefenseMaxInt = Pokemon.DefenseMaxInt;
        AtackMinInt = Pokemon.AtackMinInt;
        AtackMaxInt = Pokemon.AtackMaxInt;
        RarityInt = Pokemon.RarityInt;
        Iconint = Pokemon.Iconint;
        Spriteint = Pokemon.Spriteint;
        TypeInt = Pokemon.TypeInt;
        LevelToEvolveInt = Pokemon.LevelToEvolveInt;
        StatusInt = Pokemon.StatusInt;
        MaxHpInt = Pokemon.MaxHpInt;
        HpInt = Pokemon.HpInt;
    }

}

[System.Serializable]
public class Pokemon5Data
{
    public string Name;

    //public Sprite icon;
    public int Iconint;
    public int Spriteint;

    //public PokemonType type;
    public int TypeInt;
    public int StatusInt;

    //public PokemonRarity rarity;
    public int RarityInt;

    public int HP;
    public int maxHP;
    //public Stat AttackStat;
    public int AtackMinInt;
    public int AtackMaxInt;

    //public Stat DefenceStat;
    public int DefenseMinInt;
    public int DefenseMaxInt;

    public int Move1PP;
    public int Move2PP;
    public int Move3PP;
    public int Move4PP;

    //public PokemonStats pokemonStats;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;
    public int SpAttackStatInt;
    public int SpDefenceStatInt;

    public int MaxHpInt;
    public int HpInt;


    public bool canEvolve;
    //public PokemonEvolution evolveTo;
    public int EvolveToInt;
    public int LevelToEvolveInt;

    //public LevelUp LevelUp;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpAtackpRiseInt;
    public int AmountOfSpDeffRiseInt;
    public int AmountOfSpeedRiseInt;

    public int level;


    //public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;

    //public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();

    public Pokemon5Data(PokemonScript Pokemon)
    {
        Name = Pokemon.Name;
        //icon = Pokemon.icon;
        //type = Pokemon.type;
        //rarity = Pokemon.rarity;
        HP = Pokemon.HP;
        maxHP = Pokemon.maxHP;
        //AttackStat = Pokemon.AttackStat;
        // DefenceStat = Pokemon.DefenceStat;
        // pokemonStats = Pokemon.pokemonStats;
        // canEvolve = Pokemon.canEvolve;
        //evolveTo = Pokemon.evolveTo;
        level = Pokemon.level;
        //LevelUp = Pokemon.LevelUp;
        /*MovesICanUse[0] = Pokemon.MovesICanUse[0];
        MovesICanUse[1] = Pokemon.MovesICanUse[1];
        MovesICanUse[2] = Pokemon.MovesICanUse[2];
        MovesICanUse[3] = Pokemon.MovesICanUse[3];*/

        MovesICanUse1Int = Pokemon.MovesICanUse1Int;
        MovesICanUse2Int = Pokemon.MovesICanUse2Int;
        MovesICanUse3Int = Pokemon.MovesICanUse3Int;
        MovesICanUse4Int = Pokemon.MovesICanUse4Int;
        AmountOfHpRiseInt = Pokemon.AmountOfHpRiseInt;
        AmountOfAtackRiseInt = Pokemon.AmountOfAtackRiseInt;
        AmountOfDeffRiseInt = Pokemon.AmountOfDeffRiseInt;
        AmountOfSpeedRiseInt = Pokemon.AmountOfSpeedRiseInt;
        EvolveToInt = Pokemon.EvolveToInt;
        AttackStatInt = Pokemon.AttackStatInt;
        DefenceStatInt = Pokemon.DefenceStatInt;
        SpeedStatInt = Pokemon.SpeedStatInt;
        DefenseMinInt = Pokemon.DefenseMinInt;
        DefenseMaxInt = Pokemon.DefenseMaxInt;
        AtackMinInt = Pokemon.AtackMinInt;
        AtackMaxInt = Pokemon.AtackMaxInt;
        RarityInt = Pokemon.RarityInt;
        Iconint = Pokemon.Iconint;
        Spriteint = Pokemon.Spriteint;
        TypeInt = Pokemon.TypeInt;
        LevelToEvolveInt = Pokemon.LevelToEvolveInt;
        StatusInt = Pokemon.StatusInt;
        MaxHpInt = Pokemon.MaxHpInt;
        HpInt = Pokemon.HpInt;
    }

}

[System.Serializable]
public class Pokemon6Data
{
    public string Name;

    //public Sprite icon;
    public int Iconint;
    public int Spriteint;

    //public PokemonType type;
    public int TypeInt;
    public int StatusInt;

    //public PokemonRarity rarity;
    public int RarityInt;

    public int HP;
    public int maxHP;
    //public Stat AttackStat;
    public int AtackMinInt;
    public int AtackMaxInt;

    //public Stat DefenceStat;
    public int DefenseMinInt;
    public int DefenseMaxInt;

    public int Move1PP;
    public int Move2PP;
    public int Move3PP;
    public int Move4PP;

    //public PokemonStats pokemonStats;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;
    public int SpAttackStatInt;
    public int SpDefenceStatInt;

    public int MaxHpInt;
    public int HpInt;


    public bool canEvolve;
    //public PokemonEvolution evolveTo;
    public int EvolveToInt;
    public int LevelToEvolveInt;

    //public LevelUp LevelUp;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpAtackpRiseInt;
    public int AmountOfSpDeffRiseInt;
    public int AmountOfSpeedRiseInt;

    public int level;


    //public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;

    //public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();

    public Pokemon6Data(PokemonScript Pokemon)
    {
        Name = Pokemon.Name;
        //icon = Pokemon.icon;
        //type = Pokemon.type;
        //rarity = Pokemon.rarity;
        HP = Pokemon.HP;
        maxHP = Pokemon.maxHP;
        //AttackStat = Pokemon.AttackStat;
        // DefenceStat = Pokemon.DefenceStat;
        // pokemonStats = Pokemon.pokemonStats;
        // canEvolve = Pokemon.canEvolve;
        //evolveTo = Pokemon.evolveTo;
        level = Pokemon.level;
        //LevelUp = Pokemon.LevelUp;
        /*MovesICanUse[0] = Pokemon.MovesICanUse[0];
        MovesICanUse[1] = Pokemon.MovesICanUse[1];
        MovesICanUse[2] = Pokemon.MovesICanUse[2];
        MovesICanUse[3] = Pokemon.MovesICanUse[3];*/

        MovesICanUse1Int = Pokemon.MovesICanUse1Int;
        MovesICanUse2Int = Pokemon.MovesICanUse2Int;
        MovesICanUse3Int = Pokemon.MovesICanUse3Int;
        MovesICanUse4Int = Pokemon.MovesICanUse4Int;
        AmountOfHpRiseInt = Pokemon.AmountOfHpRiseInt;
        AmountOfAtackRiseInt = Pokemon.AmountOfAtackRiseInt;
        AmountOfDeffRiseInt = Pokemon.AmountOfDeffRiseInt;
        AmountOfSpeedRiseInt = Pokemon.AmountOfSpeedRiseInt;
        EvolveToInt = Pokemon.EvolveToInt;
        AttackStatInt = Pokemon.AttackStatInt;
        DefenceStatInt = Pokemon.DefenceStatInt;
        SpeedStatInt = Pokemon.SpeedStatInt;
        DefenseMinInt = Pokemon.DefenseMinInt;
        DefenseMaxInt = Pokemon.DefenseMaxInt;
        AtackMinInt = Pokemon.AtackMinInt;
        AtackMaxInt = Pokemon.AtackMaxInt;
        RarityInt = Pokemon.RarityInt;
        Iconint = Pokemon.Iconint;
        Spriteint = Pokemon.Spriteint;
        TypeInt = Pokemon.TypeInt;
        LevelToEvolveInt = Pokemon.LevelToEvolveInt;
        StatusInt = Pokemon.StatusInt;
        MaxHpInt = Pokemon.MaxHpInt;
        HpInt = Pokemon.HpInt;
    }

}

