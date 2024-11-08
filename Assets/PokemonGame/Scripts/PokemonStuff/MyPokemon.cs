using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPokemon : MonoBehaviour
{
    public Transform PlaceForMyPokemon;
    //public GameObject SpaceForMyPokemon;
    public PokemonScript SpaceForMyFirstPokemon;
    public PokemonScript SpaceForMySecondPokemon;
    public PokemonScript SpaceForMyThirdPokemon;
    public PokemonScript SpaceForMyFourthPokemon;
    public PokemonScript SpaceForMyFifthPokemon;
    public PokemonScript SpaceForMySixthPokemon;
    public PokeBox PokeStorage;

    private PokemonGameManager gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        AddMyPokemon(gm.AllPokemon[NameAndPartner.PartnerID-1].Name);
        SpaceForMyFirstPokemon.MyExp += 124;
        //AddMyPokemon("One");
    }


    public void AddMyPokemon(string Pokename)
    {
        if (SpaceForMyFirstPokemon.Name == "Nothing")
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            Debug.Log(Pokemon.Name);

            SpaceForMyFirstPokemon.AddMember(Pokemon);
           // gm.AddMove(1, SpaceForMyFirstPokemon);

            SpaceForMyFirstPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyFirstPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyFirstPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMySecondPokemon.Name == "Nothing")
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            Debug.Log(Pokemon.Name);
            SpaceForMySecondPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMySecondPokemon);


            SpaceForMySecondPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMySecondPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMySecondPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMyThirdPokemon.Name == "Nothing")
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            Debug.Log(Pokemon.Name);
            Debug.Log(Pokemon.AttackStat);

            SpaceForMyThirdPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMyThirdPokemon);


            SpaceForMyThirdPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyThirdPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyThirdPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMyFourthPokemon.Name == "Nothing")
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            Debug.Log(Pokemon.Name);
            Debug.Log(Pokemon.AttackStat);

            SpaceForMyFourthPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMyFourthPokemon);


            SpaceForMyFourthPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyFourthPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyFourthPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMyFifthPokemon.Name == "Nothing")
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            Debug.Log(Pokemon.Name);
            Debug.Log(Pokemon.AttackStat);

            SpaceForMyFifthPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMyFifthPokemon);


            SpaceForMyFifthPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyFifthPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyFifthPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMySixthPokemon.Name == "Nothing")
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            Debug.Log(Pokemon.Name);
            Debug.Log(Pokemon.AttackStat);

            SpaceForMySixthPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMySixthPokemon);


            SpaceForMySixthPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMySixthPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMySixthPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else
        {
            PokemonScript Pokemon = gm.GetRandomPokemonFromList(gm.GetPokemonByName(Pokename));
            PokeStorage.PokemonStorage.Add(Pokemon);
        }
    }
    public void AddCatchedPokemon(PokemonScript Pokemon)
    {
        Pokemon.AttackStat = Pokemon.AttackStatInt;
        Pokemon.DefenceStat = Pokemon.DefenceStatInt;
        Pokemon.SpeedStat = Pokemon.SpeedStatInt;
        Pokemon.maxHP = Pokemon.MaxHpInt;
        if (SpaceForMyFirstPokemon.Name == Pokemon.Name || SpaceForMySecondPokemon.Name == Pokemon.Name || SpaceForMyThirdPokemon.Name == Pokemon.Name || SpaceForMyFourthPokemon.Name == Pokemon.Name || SpaceForMyFifthPokemon.Name == Pokemon.Name || SpaceForMySixthPokemon.Name == Pokemon.Name)
        {
            PokeStorage.PokemonStorage.Add(Pokemon);
        }  else if (SpaceForMyFirstPokemon.Name == "Nothing")
        {
            SpaceForMyFirstPokemon.AddMember(Pokemon);
            // gm.AddMove(1, SpaceForMyFirstPokemon);

            SpaceForMyFirstPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyFirstPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyFirstPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMySecondPokemon.Name == "Nothing")
        {
            SpaceForMySecondPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMySecondPokemon);


            SpaceForMySecondPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMySecondPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMySecondPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMyThirdPokemon.Name == "Nothing")
        {
            SpaceForMyThirdPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMyThirdPokemon);


            SpaceForMyThirdPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyThirdPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyThirdPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMyFourthPokemon.Name == "Nothing")
        {
            SpaceForMyFourthPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMyFourthPokemon);


            SpaceForMyFourthPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyFourthPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyFourthPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMyFifthPokemon.Name == "Nothing")
        {
            SpaceForMyFifthPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMyFifthPokemon);


            SpaceForMyFifthPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMyFifthPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMyFifthPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else if (SpaceForMySixthPokemon.Name == "Nothing")
        {
            SpaceForMySixthPokemon.AddMember(Pokemon);
            //gm.AddMove(1, SpaceForMySixthPokemon);


            SpaceForMySixthPokemon.GetComponent<SpriteRenderer>().sprite = Pokemon.icon;
            SpaceForMySixthPokemon.GetComponent<Image>().sprite = Pokemon.icon;
            SpaceForMySixthPokemon.GetComponent<Image>().enabled = true;
            return;
        }
        else
        {
            PokeStorage.PokemonStorage.Add(Pokemon);
        }
    }
    public void PokemonSave()
    {
        SaveMyParameters(SpaceForMyFirstPokemon);
        SaveMyParameters(SpaceForMySecondPokemon);
        SaveMyParameters(SpaceForMyThirdPokemon);
        SaveMyParameters(SpaceForMyFourthPokemon);
        SaveMyParameters(SpaceForMyFifthPokemon);
        SaveMyParameters(SpaceForMySixthPokemon);
        SaveSystem.SavePokemon(SpaceForMyFirstPokemon, SpaceForMySecondPokemon, SpaceForMyThirdPokemon, SpaceForMyFourthPokemon, SpaceForMyFifthPokemon, SpaceForMySixthPokemon);
    }
    public void LoadAll()
    {
        Load1Pokemon(SpaceForMyFirstPokemon);
        /*Load2Pokemon(SpaceForMySecondPokemon);
        Load3Pokemon(SpaceForMyThirdPokemon);
        Load4Pokemon(SpaceForMyFourthPokemon);
        Load5Pokemon(SpaceForMyFifthPokemon);
        Load6Pokemon(SpaceForMySixthPokemon);*/
    }

    public void Load1Pokemon(PokemonScript pokemon)
    {
        PokemonData data = SaveSystem.LoadPokemon();

        pokemon.Name = data.Name;
        pokemon.HP = data.HP;
        pokemon.maxHP = data.maxHP;
        pokemon.canEvolve = data.canEvolve;
        pokemon.level = data.level;


        pokemon.MovesICanUse1Int = data.MovesICanUse1Int;
        pokemon.MovesICanUse2Int = data.MovesICanUse2Int;
        pokemon.MovesICanUse3Int = data.MovesICanUse3Int;
        pokemon.MovesICanUse4Int = data.MovesICanUse4Int;
        pokemon.AmountOfHpRiseInt = data.AmountOfHpRiseInt;
        pokemon.AmountOfAtackRiseInt = data.AmountOfAtackRiseInt;
        pokemon.AmountOfDeffRiseInt = data.AmountOfDeffRiseInt;
        pokemon.AmountOfSpeedRiseInt = data.AmountOfSpeedRiseInt;
        pokemon.EvolveToInt = data.EvolveToInt;
        pokemon.AttackStatInt = data.AttackStatInt;
        pokemon.DefenceStatInt = data.DefenceStatInt;
        pokemon.SpeedStatInt = data.SpeedStatInt;
        pokemon.DefenseMinInt = data.DefenseMinInt;
        pokemon.DefenseMaxInt = data.DefenseMaxInt;
        pokemon.AtackMinInt = data.AtackMinInt;
        pokemon.AtackMaxInt = data.AtackMaxInt;
        pokemon.RarityInt = data.RarityInt;
        pokemon.Iconint = data.Iconint;
        pokemon.Spriteint = data.Spriteint;
        pokemon.TypeInt = data.TypeInt;
        pokemon.LevelToEvolveInt = data.LevelToEvolveInt;
        LoadMovesICanUse(pokemon.MovesICanUse1Int, pokemon.MovesICanUse2Int, pokemon.MovesICanUse3Int, pokemon.MovesICanUse4Int, pokemon);
        LoadIcon(pokemon.Iconint, pokemon.Spriteint, pokemon);
        LoadMyType(pokemon);
        LoadMyRarity(pokemon);
        LoadMyLevelUp(pokemon);
        LoadMyStats(pokemon);
        LoadMyEvoleTo(pokemon);

        pokemon.GetComponent<SpriteRenderer>().sprite = pokemon.icon;

    }
    public void Load2Pokemon(PokemonScript pokemon)
    {
        Pokemon2Data data = SaveSystem.Load2Pokemon();

        pokemon.Name = data.Name;
        pokemon.HP = data.HP;
        pokemon.maxHP = data.maxHP;
        pokemon.canEvolve = data.canEvolve;
        pokemon.level = data.level;


        pokemon.MovesICanUse1Int = data.MovesICanUse1Int;
        pokemon.MovesICanUse2Int = data.MovesICanUse2Int;
        pokemon.MovesICanUse3Int = data.MovesICanUse3Int;
        pokemon.MovesICanUse4Int = data.MovesICanUse4Int;
        pokemon.AmountOfHpRiseInt = data.AmountOfHpRiseInt;
        pokemon.AmountOfAtackRiseInt = data.AmountOfAtackRiseInt;
        pokemon.AmountOfDeffRiseInt = data.AmountOfDeffRiseInt;
        pokemon.AmountOfSpeedRiseInt = data.AmountOfSpeedRiseInt;
        pokemon.EvolveToInt = data.EvolveToInt;
        pokemon.AttackStatInt = data.AttackStatInt;
        pokemon.DefenceStatInt = data.DefenceStatInt;
        pokemon.SpeedStatInt = data.SpeedStatInt;
        pokemon.DefenseMinInt = data.DefenseMinInt;
        pokemon.DefenseMaxInt = data.DefenseMaxInt;
        pokemon.AtackMinInt = data.AtackMinInt;
        pokemon.AtackMaxInt = data.AtackMaxInt;
        pokemon.RarityInt = data.RarityInt;
        pokemon.Iconint = data.Iconint;
        pokemon.Spriteint = data.Spriteint;
        pokemon.TypeInt = data.TypeInt;
        pokemon.LevelToEvolveInt = data.LevelToEvolveInt;
        LoadMovesICanUse(pokemon.MovesICanUse1Int, pokemon.MovesICanUse2Int, pokemon.MovesICanUse3Int, pokemon.MovesICanUse4Int, pokemon);
        LoadIcon(pokemon.Iconint, pokemon.Spriteint, pokemon);
        LoadMyType(pokemon);
        LoadMyRarity(pokemon);
        LoadMyLevelUp(pokemon);
        LoadMyStats(pokemon);
        LoadMyEvoleTo(pokemon);

    }
    public void Load3Pokemon(PokemonScript pokemon)
    {
        Pokemon3Data data = SaveSystem.Load3Pokemon();

        pokemon.Name = data.Name;
        pokemon.HP = data.HP;
        pokemon.maxHP = data.maxHP;
        pokemon.canEvolve = data.canEvolve;
        pokemon.level = data.level;


        pokemon.MovesICanUse1Int = data.MovesICanUse1Int;
        pokemon.MovesICanUse2Int = data.MovesICanUse2Int;
        pokemon.MovesICanUse3Int = data.MovesICanUse3Int;
        pokemon.MovesICanUse4Int = data.MovesICanUse4Int;
        pokemon.AmountOfHpRiseInt = data.AmountOfHpRiseInt;
        pokemon.AmountOfAtackRiseInt = data.AmountOfAtackRiseInt;
        pokemon.AmountOfDeffRiseInt = data.AmountOfDeffRiseInt;
        pokemon.AmountOfSpeedRiseInt = data.AmountOfSpeedRiseInt;
        pokemon.EvolveToInt = data.EvolveToInt;
        pokemon.AttackStatInt = data.AttackStatInt;
        pokemon.DefenceStatInt = data.DefenceStatInt;
        pokemon.SpeedStatInt = data.SpeedStatInt;
        pokemon.DefenseMinInt = data.DefenseMinInt;
        pokemon.DefenseMaxInt = data.DefenseMaxInt;
        pokemon.AtackMinInt = data.AtackMinInt;
        pokemon.AtackMaxInt = data.AtackMaxInt;
        pokemon.RarityInt = data.RarityInt;
        pokemon.Iconint = data.Iconint;
        pokemon.Spriteint = data.Spriteint;
        pokemon.TypeInt = data.TypeInt;
        pokemon.LevelToEvolveInt = data.LevelToEvolveInt;
        LoadMovesICanUse(pokemon.MovesICanUse1Int, pokemon.MovesICanUse2Int, pokemon.MovesICanUse3Int, pokemon.MovesICanUse4Int, pokemon);
        LoadIcon(pokemon.Iconint, pokemon.Spriteint, pokemon);
        LoadMyType(pokemon);
        LoadMyRarity(pokemon);
        LoadMyLevelUp(pokemon);
        LoadMyStats(pokemon);
        LoadMyEvoleTo(pokemon);

        pokemon.GetComponent<SpriteRenderer>().sprite = pokemon.icon;

    }
    public void Load4Pokemon(PokemonScript pokemon)
    {
        Pokemon4Data data = SaveSystem.Load4Pokemon();

        pokemon.Name = data.Name;
        pokemon.HP = data.HP;
        pokemon.maxHP = data.maxHP;
        pokemon.canEvolve = data.canEvolve;
        pokemon.level = data.level;


        pokemon.MovesICanUse1Int = data.MovesICanUse1Int;
        pokemon.MovesICanUse2Int = data.MovesICanUse2Int;
        pokemon.MovesICanUse3Int = data.MovesICanUse3Int;
        pokemon.MovesICanUse4Int = data.MovesICanUse4Int;
        pokemon.AmountOfHpRiseInt = data.AmountOfHpRiseInt;
        pokemon.AmountOfAtackRiseInt = data.AmountOfAtackRiseInt;
        pokemon.AmountOfDeffRiseInt = data.AmountOfDeffRiseInt;
        pokemon.AmountOfSpeedRiseInt = data.AmountOfSpeedRiseInt;
        pokemon.EvolveToInt = data.EvolveToInt;
        pokemon.AttackStatInt = data.AttackStatInt;
        pokemon.DefenceStatInt = data.DefenceStatInt;
        pokemon.SpeedStatInt = data.SpeedStatInt;
        pokemon.DefenseMinInt = data.DefenseMinInt;
        pokemon.DefenseMaxInt = data.DefenseMaxInt;
        pokemon.AtackMinInt = data.AtackMinInt;
        pokemon.AtackMaxInt = data.AtackMaxInt;
        pokemon.RarityInt = data.RarityInt;
        pokemon.Iconint = data.Iconint;
        pokemon.Spriteint = data.Spriteint;
        pokemon.TypeInt = data.TypeInt;
        pokemon.LevelToEvolveInt = data.LevelToEvolveInt;
        LoadMovesICanUse(pokemon.MovesICanUse1Int, pokemon.MovesICanUse2Int, pokemon.MovesICanUse3Int, pokemon.MovesICanUse4Int, pokemon);
        LoadIcon(pokemon.Iconint, pokemon.Spriteint, pokemon);
        LoadMyType(pokemon);
        LoadMyRarity(pokemon);
        LoadMyLevelUp(pokemon);
        LoadMyStats(pokemon);
        LoadMyEvoleTo(pokemon);

        pokemon.GetComponent<SpriteRenderer>().sprite = pokemon.icon;

    }
    public void Load5Pokemon(PokemonScript pokemon)
    {
        Pokemon5Data data = SaveSystem.Load5Pokemon();

        pokemon.Name = data.Name;
        pokemon.HP = data.HP;
        pokemon.maxHP = data.maxHP;
        pokemon.canEvolve = data.canEvolve;
        pokemon.level = data.level;


        pokemon.MovesICanUse1Int = data.MovesICanUse1Int;
        pokemon.MovesICanUse2Int = data.MovesICanUse2Int;
        pokemon.MovesICanUse3Int = data.MovesICanUse3Int;
        pokemon.MovesICanUse4Int = data.MovesICanUse4Int;
        pokemon.AmountOfHpRiseInt = data.AmountOfHpRiseInt;
        pokemon.AmountOfAtackRiseInt = data.AmountOfAtackRiseInt;
        pokemon.AmountOfDeffRiseInt = data.AmountOfDeffRiseInt;
        pokemon.AmountOfSpeedRiseInt = data.AmountOfSpeedRiseInt;
        pokemon.EvolveToInt = data.EvolveToInt;
        pokemon.AttackStatInt = data.AttackStatInt;
        pokemon.DefenceStatInt = data.DefenceStatInt;
        pokemon.SpeedStatInt = data.SpeedStatInt;
        pokemon.DefenseMinInt = data.DefenseMinInt;
        pokemon.DefenseMaxInt = data.DefenseMaxInt;
        pokemon.AtackMinInt = data.AtackMinInt;
        pokemon.AtackMaxInt = data.AtackMaxInt;
        pokemon.RarityInt = data.RarityInt;
        pokemon.Iconint = data.Iconint;
        pokemon.Spriteint = data.Spriteint;
        pokemon.TypeInt = data.TypeInt;
        pokemon.LevelToEvolveInt = data.LevelToEvolveInt;
        LoadMovesICanUse(pokemon.MovesICanUse1Int, pokemon.MovesICanUse2Int, pokemon.MovesICanUse3Int, pokemon.MovesICanUse4Int, pokemon);
        LoadIcon(pokemon.Iconint, pokemon.Spriteint, pokemon);
        LoadMyType(pokemon);
        LoadMyRarity(pokemon);
        LoadMyLevelUp(pokemon);
        LoadMyStats(pokemon);
        LoadMyEvoleTo(pokemon);

        pokemon.GetComponent<SpriteRenderer>().sprite = pokemon.icon;

    }
    public void Load6Pokemon(PokemonScript pokemon)
    {
        Pokemon6Data data = SaveSystem.Load6Pokemon();

        pokemon.Name = data.Name;
        pokemon.HP = data.HP;
        pokemon.maxHP = data.maxHP;
        pokemon.canEvolve = data.canEvolve;
        pokemon.level = data.level;


        pokemon.MovesICanUse1Int = data.MovesICanUse1Int;
        pokemon.MovesICanUse2Int = data.MovesICanUse2Int;
        pokemon.MovesICanUse3Int = data.MovesICanUse3Int;
        pokemon.MovesICanUse4Int = data.MovesICanUse4Int;
        pokemon.AmountOfHpRiseInt = data.AmountOfHpRiseInt;
        pokemon.AmountOfAtackRiseInt = data.AmountOfAtackRiseInt;
        pokemon.AmountOfDeffRiseInt = data.AmountOfDeffRiseInt;
        pokemon.AmountOfSpeedRiseInt = data.AmountOfSpeedRiseInt;
        pokemon.EvolveToInt = data.EvolveToInt;
        pokemon.AttackStatInt = data.AttackStatInt;
        pokemon.DefenceStatInt = data.DefenceStatInt;
        pokemon.SpeedStatInt = data.SpeedStatInt;
        pokemon.DefenseMinInt = data.DefenseMinInt;
        pokemon.DefenseMaxInt = data.DefenseMaxInt;
        pokemon.AtackMinInt = data.AtackMinInt;
        pokemon.AtackMaxInt = data.AtackMaxInt;
        pokemon.RarityInt = data.RarityInt;
        pokemon.Iconint = data.Iconint;
        pokemon.Spriteint = data.Spriteint;
        pokemon.TypeInt = data.TypeInt;
        pokemon.LevelToEvolveInt = data.LevelToEvolveInt;
        LoadMovesICanUse(pokemon.MovesICanUse1Int, pokemon.MovesICanUse2Int, pokemon.MovesICanUse3Int, pokemon.MovesICanUse4Int, pokemon);
        LoadIcon(pokemon.Iconint, pokemon.Spriteint, pokemon);
        LoadMyType(pokemon);
        LoadMyRarity(pokemon);
        LoadMyLevelUp(pokemon);
        LoadMyStats(pokemon);
        LoadMyEvoleTo(pokemon);

        pokemon.GetComponent<SpriteRenderer>().sprite = pokemon.icon;

    }
    public void LoadIcon(int Icon, int sprite, PokemonScript Pokemon)
    {
        Pokemon.icon = gm.AllPokemon[Icon-1].icon;
        Pokemon.sprite = gm.AllPokemon[sprite - 1].sprite;
    }
    public void LoadMovesICanUse(int one, int two, int three, int four, PokemonScript Pokemon)
    {
        /*
        if (SpaceForMyFirstPokemon.MovesICanUse1Int == 0)
        {
            SpaceForMyFirstPokemon.MovesICanUse[0] = gm.AllMoves[0];
        }
        if (SpaceForMyFirstPokemon.MovesICanUse1Int == 1)
        {
            SpaceForMyFirstPokemon.MovesICanUse[1] = gm.AllMoves[1];
        }
        if (SpaceForMyFirstPokemon.MovesICanUse1Int == 2)
        {
            SpaceForMyFirstPokemon.MovesICanUse[2] = gm.AllMoves[2];
        }
        if (SpaceForMyFirstPokemon.MovesICanUse1Int == 3)
        {
            SpaceForMyFirstPokemon.MovesICanUse[3] = gm.AllMoves[3];
        }
        if (SpaceForMyFirstPokemon.MovesICanUse1Int == 4)
        {
            SpaceForMyFirstPokemon.MovesICanUse[4] = gm.AllMoves[4];
        }*/
        Pokemon.MovesICanUse[0] = gm.AllMoves[one];
        Pokemon.MovesICanUse[1] = gm.AllMoves[two];
        Pokemon.MovesICanUse[2] = gm.AllMoves[three];
        Pokemon.MovesICanUse[3] = gm.AllMoves[four];

    }
    public void LoadMyLevelUp(PokemonScript Pokemon)
    {
        Pokemon.LevelUp.AmountOfAtackRise = Pokemon.AmountOfAtackRiseInt;
        Pokemon.LevelUp.AmountOfDeffRise = Pokemon.AmountOfDeffRiseInt;
        Pokemon.LevelUp.AmountOfHpRise = Pokemon.AmountOfHpRiseInt;
        Pokemon.LevelUp.AmountOfSpeedRise = Pokemon.AmountOfSpeedRiseInt;
    }
    public void LoadMyStats(PokemonScript Pokemon)
    {
        Pokemon.AttackStat = Pokemon.AttackStatInt;
        Pokemon.DefenceStat = Pokemon.DefenceStatInt;
        Pokemon.SpeedStat = Pokemon.SpeedStatInt;
    }
    public void LoadMyType(PokemonScript Pokemon)
    {
        if (Pokemon.TypeInt == 0)
        {
            Pokemon.type = PokemonType.Normal;
        }
        if (Pokemon.TypeInt == 1)
        {
            Pokemon.type = PokemonType.Water;
        }
        if (Pokemon.TypeInt == 2)
        {
            Pokemon.type = PokemonType.Fire;
        }
        if (Pokemon.TypeInt == 3)
        {
            Pokemon.type = PokemonType.Grass;
        }
    }
    public void LoadMyRarity(PokemonScript Pokemon)
    {
        if (Pokemon.RarityInt == 0)
        {
            Pokemon.rarity = PokemonRarity.Common;
        }
        if (Pokemon.RarityInt == 1)
        {
            Pokemon.rarity = PokemonRarity.Rare;
        }
        if (Pokemon.RarityInt == 2)
        {
            Pokemon.rarity = PokemonRarity.Epic;
        }
        if (Pokemon.RarityInt == 3)
        {
            Pokemon.rarity = PokemonRarity.LEGENDARY;
        }
    }
    public void LoadMyEvoleTo(PokemonScript Pokemon)
    {
        if (Pokemon.EvolveToInt != 0)
        {
            Pokemon.evolveTo.nextEvolution = gm.AllPokemon[Pokemon.EvolveToInt];
        }
        Pokemon.evolveTo.levelUpLevel = Pokemon.LevelToEvolveInt;
    }

    public void SaveMyParameters(PokemonScript pokemon)
    {
        pokemon.AmountOfHpRiseInt = pokemon.LevelUp.AmountOfHpRise;
        pokemon.AmountOfAtackRiseInt = pokemon.LevelUp.AmountOfAtackRise;
        pokemon.AmountOfDeffRiseInt = pokemon.LevelUp.AmountOfDeffRise;
        pokemon.AmountOfSpeedRiseInt = pokemon.LevelUp.AmountOfSpeedRise;
        pokemon.AttackStatInt = pokemon.AttackStat;
        pokemon.DefenceStatInt = pokemon.DefenceStat;
        pokemon.SpeedStatInt = pokemon.SpeedStat;
    }
}
