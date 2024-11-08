using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PokemonScript : MonoBehaviour
{

    public string Name;
    public Sprite icon;
    public Sprite sprite;
    public PokemonType type;
    public PokemonRarity rarity;
    public Status status;
    public int HP;
    public int maxHP;
    public int ExpForMe;
    public int MyExp;
    public int MaxExp = 1000000;

    public int AttackStat;
    public int DefenceStat;
    public int SpeedStat;

    public int HpLossInt;

    public bool canEvolve;
    public PokemonEvolution evolveTo;
    public LevelUp LevelUp;


    public int level;

    
    public List<PokemonMoves> MovesICanUse = new List<PokemonMoves>();
    public List<PokemonMoves> MovesICanLearn = new List<PokemonMoves>();


    public int MovesICanUse1Int;
    public int MovesICanUse2Int;
    public int MovesICanUse3Int;
    public int MovesICanUse4Int;
    public int AmountOfHpRiseInt;
    public int AmountOfAtackRiseInt;
    public int AmountOfDeffRiseInt;
    public int AmountOfSpeedRiseInt;
    public int EvolveToInt;
    public int AttackStatInt;
    public int DefenceStatInt;
    public int SpeedStatInt;
    public int DefenseMinInt;
    public int DefenseMaxInt;
    public int AtackMinInt;
    public int AtackMaxInt;
    public int RarityInt;
    public int Iconint;
    public int Spriteint;
    public int TypeInt;
    public int LevelToEvolveInt;
    public int StatusInt;
    public int MaxHpInt;
    public int HpInt;

    public string Description;
    public List<QuestionToCatch> QuizToCatch = new List<QuestionToCatch>();


    public void AddMember(PokemonScript bp)
    {
        this.GetComponent<SpriteRenderer>().sprite = bp.GetComponent<SpriteRenderer>().sprite;
        this.Name = bp.Name;
        this.icon = bp.icon;
        this.sprite = bp.sprite;
        this.type = bp.type;
        this.rarity = bp.rarity;
        this.HP = bp.HP;
        this.maxHP = bp.maxHP;
        this.AttackStat = bp.AttackStat;
        this.DefenceStat = bp.DefenceStat;
        this.SpeedStat = bp.SpeedStat;

        this.canEvolve = bp.canEvolve;
        this.evolveTo = bp.evolveTo;
        this.level = bp.level;
        this.LevelUp = bp.LevelUp;
        this.MovesICanUse[0] = bp.MovesICanUse[0];
        this.MovesICanUse[1] = bp.MovesICanUse[1];
        this.MovesICanUse[2] = bp.MovesICanUse[2];
        this.MovesICanUse[3] = bp.MovesICanUse[3];
        this.status = bp.status;
        this.QuizToCatch = bp.QuizToCatch;

        //Save

        this.MovesICanUse1Int = bp.MovesICanUse1Int;
        this.MovesICanUse2Int = bp.MovesICanUse2Int;
        this.MovesICanUse3Int = bp.MovesICanUse3Int;
        this.MovesICanUse4Int = bp.MovesICanUse4Int;
        this.AmountOfHpRiseInt = bp.AmountOfHpRiseInt;
        this.AmountOfAtackRiseInt = bp.AmountOfAtackRiseInt;
        this.AmountOfDeffRiseInt = bp.AmountOfDeffRiseInt;
        this.AmountOfSpeedRiseInt = bp.AmountOfSpeedRiseInt;
        this.EvolveToInt = bp.EvolveToInt;
        this.AttackStatInt = bp.AttackStatInt;
        this.DefenceStatInt = bp.DefenceStatInt;
        this.SpeedStatInt = bp.SpeedStatInt;
        this.DefenseMinInt = bp.DefenseMinInt;
        this.DefenseMaxInt = bp.DefenseMaxInt;
        this.AtackMinInt = bp.AtackMinInt;
        this.AtackMaxInt = bp.AtackMaxInt;
        this.RarityInt = bp.RarityInt;
        this.Iconint = bp.Iconint;
        this.Spriteint = bp.Spriteint;
        this.TypeInt = bp.TypeInt;
        this.StatusInt = bp.StatusInt;
        this.MaxHpInt = bp.MaxHpInt;
        this.HpInt = bp.HpInt;
        this.MyExp = bp.MyExp;
        this.MaxExp = bp.MaxExp;
        this.ExpForMe = bp.ExpForMe;
        this.HpLossInt = bp.HpLossInt;
        this.Description = bp.Description;
    }
    public void PokemonLevelUp()
    {
        AttackStat += LevelUp.AmountOfAtackRise;
        DefenceStat += LevelUp.AmountOfDeffRise;
        maxHP += LevelUp.AmountOfHpRise;
        SpeedStat += LevelUp.AmountOfSpeedRise;
        HP += LevelUp.AmountOfHpRise;
    }


}
[System.Serializable]
public enum PokemonType
{
    Normal,
    Water,
    Fire,
    Grass,

    Noxus,
    Demacia,
    Shurima,
    Piltover,
    Zaun,
    Void,
    Targon,
    Ixtal,
    Bilgewater,
    Freljord,
    Ionia,
    Bandle_City,
    Shadow_Isles
}
[System.Serializable]
public enum PokemonRarity
{
    LEGENDARY,
    Epic,
    Rare,
    Common
}
[System.Serializable]
public enum Status
{
    Nothing,
    Paranoia,
    Watcher,
    Poisoned,
    CantDodge,
    Burned,
    Bleeding

}
[System.Serializable]
public class PokemonEvolution
{
    public PokemonScript nextEvolution;
    public int levelUpLevel;
}

[System.Serializable]
public class LevelUp
{
    public int AmountOfHpRise;
    public int AmountOfAtackRise;
    public int AmountOfDeffRise;
    public int AmountOfSpeedRise;
}
[System.Serializable]
public class Stat
{
    public int minimum;
    public int maximum;
}
