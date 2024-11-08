using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoAboutPokemon : MonoBehaviour
{
    public PokemonScript ThisPokemon;
    public PokemonScript MyPokemon;
    public PokemonScript Pokemon1;
    public PokemonScript Pokemon2;
    public PokemonScript Pokemon3;
    public PokemonScript Pokemon4;
    public PokemonScript Pokemon5;
    public PokemonScript Pokemon6;
    public Text Name;
    public Text Type;
    public Text Lvl;
    public Text MyName;
    public Text MyType;
    public Text MyLvl;
    public Text Hp;
    public Text MyHp;

    public GameObject Menu;
    public GameObject Tips;

    public GameObject GOInfo;
    public Image Info;
    public Text ShowName;
    public Text ShowType;
    public Text ShowLvl;
    public Text ShowAtk;
    public Text ShowSpAtk;
    public Text ShowDef;
    public Text ShowSpDef;
    public Text Showpeed;
    public Text ShowHp;
    public Text ShowExp;
    public Text ShowShortInfoABoutChamp;

    public Text Attac1kName;
    public Text Attac2kName;
    public Text Attac3kName;
    public Text Attac4kName;

    public Text Attack1Des;
    public Text Attack2Des;
    public Text Attack3Des;
    public Text Attack4Des;

    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;

    public GameObject Next2;
    public GameObject Next3;
    public GameObject Next4;
    public GameObject Next5;
    public GameObject Next6;

    public GameObject Previous1;
    public GameObject Previous2;
    public GameObject Previous3;
    public GameObject Previous4;
    public GameObject Previous5;

    public GameObject Image;
    public GameObject Atk;

    public string LevelToLoad;
    bool one;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowInfoAboutPokemon()
    {
        Name.text = "Name: " + ThisPokemon.Name.ToString();
        Type.text = "Region: " + ThisPokemon.type.ToString();
        Lvl.text = "Level: " + ThisPokemon.level.ToString();
        Hp.text = ThisPokemon.HP.ToString() + " / " + ThisPokemon.maxHP.ToString();

        MyName.text = "Name: " + MyPokemon.Name.ToString();
        MyType.text = "Region: " + MyPokemon.type.ToString();
        MyLvl.text = "Level: " + MyPokemon.level.ToString();
        MyHp.text = MyPokemon.HP.ToString() + " / " + MyPokemon.maxHP.ToString();
    }
    public void MenuInfo()
    {
        Menu.SetActive(false);
        
        GOInfo.SetActive(true);
        Image.SetActive(true);
        ShowChampStat(Pokemon1);

    }
    public void ShowInfFirstPoke()
    {
        ShowChampStat(Pokemon1);
    }
    public void Poke1()
    {
        ShowChampStat(Pokemon1);
        B1.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);

        Next2.SetActive(true);
        Next3.SetActive(false);
        Previous1.SetActive(false);
    }
    public void Poke2()
    {
        ShowChampStat(Pokemon2);
        B2.SetActive(true);

        B1.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);

        Next3.SetActive(true);
        Previous1.SetActive(true);
        Next2.SetActive(false);
        Next4.SetActive(false);
        Previous2.SetActive(false);
    }
    public void Poke3()
    {
        ShowChampStat(Pokemon3);
        B3.SetActive(true);

        B2.SetActive(false);
        B1.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);

        Next4.SetActive(true);
        Previous2.SetActive(true);
        Next3.SetActive(false);
        Next5.SetActive(false);
        Previous3.SetActive(false);
        Previous1.SetActive(false);
    }
    public void Poke4()
    {
        ShowChampStat(Pokemon4);
        B4.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B1.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);

        Next5.SetActive(true);
        Previous3.SetActive(true);
        Next6.SetActive(false);
        Next4.SetActive(false);
        Previous2.SetActive(false);
        Previous4.SetActive(false);
    }
    public void Poke5()
    {
        ShowChampStat(Pokemon5);
        B5.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B1.SetActive(false);
        B6.SetActive(false);

        Next6.SetActive(true);
        Previous4.SetActive(true);
        Next5.SetActive(false);
        Previous5.SetActive(false);
        Previous3.SetActive(false);
    }
    public void Poke6()
    {
        ShowChampStat(Pokemon6);
        B6.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B1.SetActive(false);

        Previous5.SetActive(true);
        Next6.SetActive(false);
        Previous4.SetActive(false);
    }


    public void APoke1()
    {
        ShowAttack(Pokemon1);
        Image.SetActive(false);
        B1.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);
    }
    public void APoke2()
    {
        ShowAttack(Pokemon2);
        Image.SetActive(false);
        B2.SetActive(true);

        B1.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);
    }
    public void APoke3()
    {
        ShowAttack(Pokemon3);
        Image.SetActive(false);
        B3.SetActive(true);

        B2.SetActive(false);
        B1.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);
    }
    public void APoke4()
    {
        ShowAttack(Pokemon4);
        Image.SetActive(false);
        B4.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B1.SetActive(false);
        B5.SetActive(false);
        B6.SetActive(false);
    }
    public void APoke5()
    {
        ShowAttack(Pokemon5);
        Image.SetActive(false);
        B5.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B1.SetActive(false);
        B6.SetActive(false);
    }
    public void APoke6()
    {
        ShowAttack(Pokemon6);
        Image.SetActive(false);
        B6.SetActive(true);

        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
        B5.SetActive(false);
        B1.SetActive(false);
    }


    public void Return()
    {
        Menu.SetActive(true);

        GOInfo.SetActive(false);
        Tips.SetActive(false);

        B1.SetActive(true);
    }
    public void Return2()
    {
        Image.SetActive(true);
        Atk.SetActive(false);
    }
    public void ShowChampStat(PokemonScript Poke)
    {
        CheckLevel(Poke);
        Info.sprite = Poke.icon;
        ShowName.text = Poke.Name;
        ShowType.text = Poke.type.ToString();
        ShowLvl.text = "Level: " + Poke.level.ToString();
        ShowAtk.text = "Atack: " + (Poke.AttackStat + (Poke.LevelUp.AmountOfAtackRise * (Poke.level - 1))).ToString();
        ShowDef.text = "Defense: " + (Poke.DefenceStat + (Poke.LevelUp.AmountOfDeffRise * (Poke.level - 1))).ToString();
        Showpeed.text = "Spped: " + (Poke.SpeedStat + (Poke.LevelUp.AmountOfSpeedRise * (Poke.level - 1))).ToString();
        ShowHp.text = ((Poke.maxHP + Poke.LevelUp.AmountOfHpRise * (Poke.level - 1)) - Poke.HpLossInt) + "/" + (Poke.maxHP + Poke.LevelUp.AmountOfHpRise * (Poke.level - 1)) + " HP";
        ShowExp.text = Poke.MyExp.ToString() + "/" + Poke.MaxExp + " Exp";
        ShowShortInfoABoutChamp.text = Poke.Description;
        print((Poke.LevelUp.AmountOfAtackRise * (Poke.level - 1)).ToString());
    }
    public void ShowAttack(PokemonScript Poke)
    {
        Atk.SetActive(true);

        Attac1kName.text = Poke.MovesICanUse[0].Name;
        Attac2kName.text = Poke.MovesICanUse[1].Name;
        Attac3kName.text = Poke.MovesICanUse[2].Name;
        Attac4kName.text = Poke.MovesICanUse[3].Name;

        Attack1Des.text = Poke.MovesICanUse[0].Description;
        Attack2Des.text = Poke.MovesICanUse[1].Description;
        Attack3Des.text = Poke.MovesICanUse[2].Description;
        Attack4Des.text = Poke.MovesICanUse[3].Description;
    }
    public void ExitInfo()
    {
        GOInfo.SetActive(false);
        Image.SetActive(false);
    }
    public void ShowTips()
    {
        GOInfo.SetActive(true);
        Tips.SetActive(true);
    }
    public void Exit()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    public void CheckLevel(PokemonScript Poke)
    {
        int MyLevel;
        for (int i = 0; i < 100; i++)
        {
            if ((i * i * i) > Poke.MyExp)
            {
                MyLevel = i - 1;
                Poke.level = MyLevel;
                break;
            }
        }
    }
}
