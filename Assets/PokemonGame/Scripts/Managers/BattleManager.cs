using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject battleCamera;

    public GameObject FightUI;

    public GameObject FightMenu;
    public GameObject FightFIght;
    public GameObject FightItem;
    public GameObject FightChangePokemon;
    public GameObject FightRunAway;

    public GameObject PokeScene;

    public Image IconPoke1;
    public Image IconPoke2;
    public Image IconPoke3;
    public Image IconPoke4;
    public Image IconPoke5;
    public Image IconPoke6;

    public PokemonScript MyPokemon;

    public PokemonScript Pokemon1;
    public PokemonScript Pokemon2;
    public PokemonScript Pokemon3;
    public PokemonScript Pokemon4;
    public PokemonScript Pokemon5;
    public PokemonScript Pokemon6;
    
    public PokemonScript EnemyPokemon;

    public Text NamePoke1;
    public Text NamePoke2;
    public Text NamePoke3;
    public Text NamePoke4;
    public Text NamePoke5;
    public Text NamePoke6;

    public Text NameMove1;
    public Text NameMove2;
    public Text NameMove3;
    public Text NameMove4;

    public Text PPMove1;
    public Text PPMove2;
    public Text PPMove3;
    public Text PPMove4;

    public Text MoneyText;
    public int AmountOfMoney;

    public int demage;

    public GameObject LOG;

    public GameObject MyInfo;
    public GameObject EnemyInfo;

    public Image Log;

    public Text LogText;

    private InfoAboutPokemon PokeInfo;

    private PokemonGameManager gm;

    private NoxusMoves NoxusMoves;

    public FIrstPokemon First;

    private Dialog DMan;

    private string CoPowiedziec;

    public bool walka = false;


    public int Exp;

    public int a = 1;

    public int TourNumber;

    public GameObject Demacia;
    public GameObject Piltover;
    public GameObject Ionia;
    public GameObject Void;
    public GameObject Freljord;
    public GameObject Shurima;
    public GameObject Zaun;
    public GameObject Targon;
    public GameObject BandleCity;
    public GameObject ShadowIsles;
    public GameObject Bilgewater;
    public GameObject Noxus;

    private bool wygrana;
    private void Start()
    {
        DMan = FindObjectOfType<Dialog>();
        TourNumber = 0;
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        PokeInfo = GameObject.FindGameObjectWithTag("Info").GetComponent<InfoAboutPokemon>();
        NoxusMoves = GameObject.FindGameObjectWithTag("NoxusMoves").GetComponent<NoxusMoves>();
    }

    public void StartFight()
    {
        walka = true;
        CatMove CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        CM.MozeChodzic = false;

        LOG.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightFIght.SetActive(false);
        FightItem.SetActive(false);
        FightMenu.SetActive(false);
        MyInfo.SetActive(false);
        EnemyInfo.SetActive(false);
        FightUI.SetActive(true);
        SceneReset();

        TourNumber = 0;

        LogText.text = "Enemy Champion appeared";
        StartCoroutine("StartFightInfo", true);

        
    }
    IEnumerator StartFightInfo(bool wait)
    {
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                LogText.text = "It's " + EnemyPokemon.Name + "!!!";
                wait = false;
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                LogText.text = MyPokemon.Name + " GO!!!";
                wait = false;
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                LOG.SetActive(false);
                FightMenu.SetActive(true);
                MyInfo.SetActive(true);
                EnemyInfo.SetActive(true);
                wait = false;
            }
            yield return null;
        }
    }
    IEnumerator ChangePokemon(bool wait)
    {
        LOG.SetActive(true);
        FightMenu.SetActive(false);
        FightChangePokemon.SetActive(false);
        MyInfo.SetActive(true);
        EnemyInfo.SetActive(true);
        LogText.text = MyPokemon.Name + " GO!!!";
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                EnemyTour();
                wait = false;
            }
            yield return null;
        }
        /*
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                LOG.SetActive(false);
                FightMenu.SetActive(true);
                MyInfo.SetActive(true);
                EnemyInfo.SetActive(true);
                wait = false;
            }
            yield return null;
        }
        */
    }
    IEnumerator MyAttackLog(bool wait, int i)
    {
        wait = true;
        bool end = false;
        LOG.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightFIght.SetActive(false);
        FightItem.SetActive(false);
        FightMenu.SetActive(false);
        MyInfo.SetActive(false);
        EnemyInfo.SetActive(false);
        FightUI.SetActive(false);
        if (MyPokemon.MovesICanUse[i].category != MoveType.Status && MyPokemon.status != Status.Paranoia)
        {
            LogText.text = MyPokemon.Name + " use " + MyPokemon.MovesICanUse[i].Name + "!!! And deal " + (int)NoxusMoves.DMG + "HP!";
        }
        else if (MyPokemon.MovesICanUse[i].category != MoveType.Status && MyPokemon.status == Status.Paranoia)
        {
            LogText.text = MyPokemon.Name + " use " + MyPokemon.MovesICanUse[i].Name + "!!! And deal " + (int)NoxusMoves.DMG + "HP to himself becouse of his paranoia!";
            MyPokemon.status = Status.Nothing;
            NoxusMoves.MyPokemon = MyPokemon;
            NoxusMoves.EnemyPokemon = EnemyPokemon;
            wait = false;
        }
        else
        {
            LogText.text = MyPokemon.Name + " use " + MyPokemon.MovesICanUse[i].Name + "!!!";
        }



        if (MyPokemon.MovesICanUse[i].RiseATK == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s attack rise!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].RiseDef == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s defense rise!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].RiseSpeed == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s speed rise!!!";
                    wait = false;
                }
                yield return null;
            }
        }

        if (MyPokemon.MovesICanUse[i].MeDecreaseATK == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s attack decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].MeDecreaseSpeed == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s speed decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].MeDecreaseDeff == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s defense decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }

        if (MyPokemon.MovesICanUse[i].DecreaseATK == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s attack decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].DecreaseSpeed == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s speed decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].DecreaseDeff == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s defense decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        // special cases
        if (MyPokemon.MovesICanUse[i].MyIndex == 3 && MyPokemon.MovesICanUse[i].MyIndex == 16 && MyPokemon.MovesICanUse[i].MyIndex == 22)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = "Thanks to " + MyPokemon.MovesICanUse[i].Name + " " + MyPokemon.Name + " healed some Hp!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].MyIndex == 8)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.MovesICanUse[i].Name + " summon " + NoxusMoves.quantity + " larvas and deal " + (int)NoxusMoves.DMG + "HP!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].MyIndex == 20)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.MovesICanUse[i].Name + " call homies and " + NoxusMoves.quantity + " homies came, they deal " + (int)NoxusMoves.DMG + "HP!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].MyIndex == 13)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.MovesICanUse[i].Name + " heal " + (int)(NoxusMoves.DMG / 2) + "HP!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.MovesICanUse[i].MyIndex == 21)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.MovesICanUse[i].Name + " suffocate enemy for " + NoxusMoves.quantity + "seconds and deal" + NoxusMoves.DMG * NoxusMoves.quantity + " HP!";
                    wait = false;
                }
                yield return null;
            }
        }
        ////////////////

        if (EnemyPokemon.HP <= 0)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = "wygrańsko!";
                    wygrana = true;
                    MoneyForWin();
                    end = true;
                    wait = false;
                }
                yield return null;
            }
        }
        else
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LOG.SetActive(false);
                    FightMenu.SetActive(true);
                    FightUI.SetActive(true);
                    MyInfo.SetActive(true);
                    EnemyInfo.SetActive(true);
                    EnemyTour();
                    TourNumber++;
                    PokeInfo.ShowInfoAboutPokemon();
                    wait = false;
                }
                yield return null;
            }
        }

        if (end == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    EndFight();
                    wait = false;
                }
                yield return null;
            }
        }


    }
    IEnumerator EnemyAttackLog(bool wait, int i)
    {
        wait = true;
        bool end = false;
        LOG.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightFIght.SetActive(false);
        FightItem.SetActive(false);
        FightMenu.SetActive(false);
        MyInfo.SetActive(false);
        EnemyInfo.SetActive(false);
        FightUI.SetActive(false);


        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                if (EnemyPokemon.MovesICanUse[i].category != MoveType.Status && EnemyPokemon.status != Status.Paranoia)
                {
                    LogText.text = EnemyPokemon.Name + " use " + EnemyPokemon.MovesICanUse[i].Name + "!!! And deal " + (int)NoxusMoves.DMG + "HP!";
                    wait = false;
                }
                else if(EnemyPokemon.MovesICanUse[i].category != MoveType.Status && EnemyPokemon.status == Status.Paranoia)
                {
                    LogText.text = EnemyPokemon.Name + " use " + EnemyPokemon.MovesICanUse[i].Name + "!!! And deal " + (int)NoxusMoves.DMG + "HP to himself becouse of his paranoia!";
                    EnemyPokemon.status = Status.Nothing;
                    NoxusMoves.MyPokemon = MyPokemon;
                    NoxusMoves.EnemyPokemon = EnemyPokemon;
                    wait = false;
                }
                else
                {
                    LogText.text = EnemyPokemon.Name + " use " + EnemyPokemon.MovesICanUse[i].Name + "!!!";
                    wait = false;
                }
            }
            yield return null;
        }
        if (EnemyPokemon.MovesICanUse[i].RiseATK == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s attack rise!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].RiseDef == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s defense rise!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].RiseSpeed == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s speed rise!!!";
                    wait = false;
                }
                yield return null;
            }
        }

        if (EnemyPokemon.MovesICanUse[i].MeDecreaseATK == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s attack decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].MeDecreaseSpeed == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s speed decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].MeDecreaseDeff == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.Name + "'s defense decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }

        if (EnemyPokemon.MovesICanUse[i].DecreaseATK == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s attack decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].DecreaseSpeed == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s speed decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].DecreaseDeff == true)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "'s defense decrease!!!";
                    wait = false;
                }
                yield return null;
            }
        }
        ////////////////////////////
        if (EnemyPokemon.MovesICanUse[i].MyIndex == 3 && EnemyPokemon.MovesICanUse[i].MyIndex == 16 && EnemyPokemon.MovesICanUse[i].MyIndex == 22)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = "Thanks to " + EnemyPokemon.MovesICanUse[i].Name + " " + EnemyPokemon.Name + " healed some Hp!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].MyIndex == 8)
        {
                wait = true;
                while (wait)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        LogText.text = EnemyPokemon.MovesICanUse[i].Name + " summon " + NoxusMoves.quantity + " larvas and deal " + (int)NoxusMoves.DMG + "HP!";
                        wait = false;
                    }
                    yield return null;
                }
        }
        if (EnemyPokemon.MovesICanUse[i].MyIndex == 20)
        {
                wait = true;
                while (wait)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        LogText.text = EnemyPokemon.MovesICanUse[i].Name + " call homies and " + NoxusMoves.quantity + " homies came, they deal " + (int)NoxusMoves.DMG + "HP!";
                        wait = false;
                    }
                    yield return null;
                }
        }
        if (EnemyPokemon.MovesICanUse[i].MyIndex == 13)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.MovesICanUse[i].Name + " heal " + (int)(NoxusMoves.DMG / 2) + "HP!";
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.MovesICanUse[i].MyIndex == 21)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = EnemyPokemon.MovesICanUse[i].Name + " suffocate enemy for " + NoxusMoves.quantity + "seconds and deal" + NoxusMoves.DMG*NoxusMoves.quantity+" HP!";
                    wait = false;
                }
                yield return null;
            }
        }
        ////////////////////////////
        if (MyPokemon.status != Status.Nothing)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    Effect(MyPokemon);
                    wait = false;
                }
                yield return null;
            }
        }
        if (EnemyPokemon.status != Status.Nothing)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    Effect(EnemyPokemon);
                    wait = false;
                }
                yield return null;
            }
        }
        ////////////////////////////
        bool change = false;
        if (MyPokemon.HP <= 0)
        {
            wait = true;
            while (wait)
            {
                SaveBattleEfects();
                if (Pokemon1.HP<=0 && Pokemon2.HP <= 0 && Pokemon3.HP <= 0 && Pokemon4.HP <= 0 && Pokemon5.HP <= 0 && Pokemon6.HP <= 0)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        LogText.text = "You lost!";
                        end = true;
                        wait = false;
                    }
                    yield return null;
                }
                else
                {
                    change = true;
                    wait = false;
                }
                yield return null;
            }
        }
        if (MyPokemon.HP <= 0 && change)
        {
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    LogText.text = MyPokemon.Name + "lost, choose other hero!";
                    wait = false;
                }
                yield return null;
            }
            wait = true;
            while (wait)
            {
                if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                {
                    wait = false;
                }
                yield return null;
            }
            LOG.SetActive(false);
            FightMenu.SetActive(true);
            FightUI.SetActive(true);
            MyInfo.SetActive(true);
            EnemyInfo.SetActive(true);
            PokeInfo.ShowInfoAboutPokemon();
            ChangePokemon();
        }
        else
        {
            if (EnemyPokemon.HP <= 0)
            {
                wait = true;
                while (wait)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        LogText.text = "wygrańsko!";
                        wygrana = true;
                        MoneyForWin();
                        end = true;
                        wait = false;
                    }
                    yield return null;
                }
            }
            else if (end == false)
            {
                /*
                wait = true;
                while (wait)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        RegionEffect(MyPokemon, EnemyPokemon);
                        wait = false;
                    }
                    yield return null;
                }
                if (MyPokemon.type == PokemonType.Shadow_Isles && EnemyPokemon.type == PokemonType.Shadow_Isles)
                {
                    // :D
                }
                else
                {
                    wait = true;
                    while (wait)
                    {
                        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                        {
                            RegionEffectEnemy(MyPokemon, EnemyPokemon);
                            wait = false;
                        }
                        yield return null;
                    }
                }
                */
                wait = true;
                while (wait)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        LOG.SetActive(false);
                        FightMenu.SetActive(true);
                        FightUI.SetActive(true);
                        MyInfo.SetActive(true);
                        EnemyInfo.SetActive(true);
                        PokeInfo.ShowInfoAboutPokemon();
                        wait = false;
                    }
                    yield return null;
                }
            }
            if (end == true)
            {
                wait = true;
                while (wait)
                {
                    if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
                    {
                        EndFight();
                        wait = false;
                    }
                    yield return null;
                }
            }
        }
    }

    public void Fight()
    {
        FightMenu.SetActive(false);
        FightFIght.SetActive(true);
        
        NameMove1.text = MyPokemon.MovesICanUse[0].Name;
        if (MyPokemon.MovesICanUse[1] != gm.AllMoves[0])
        {
            PokemonMoves MysecondMove = MyPokemon.MovesICanUse[1];
            NameMove2.text = MyPokemon.MovesICanUse[1].Name;
        }
        else
        {
            PokemonMoves MysecondMove = MyPokemon.MovesICanUse[1];
            NameMove2.text = "Empty";
        }
        if (MyPokemon.MovesICanUse[2] != gm.AllMoves[0])
        {
            PokemonMoves MyThirdMove = MyPokemon.MovesICanUse[2];
            NameMove3.text = MyPokemon.MovesICanUse[2].Name;
        }
        else
        {
            PokemonMoves MyThirdMove = MyPokemon.MovesICanUse[2];
            NameMove3.text = "Empty";
        }
        if (MyPokemon.MovesICanUse[3] != gm.AllMoves[0])
        {
            PokemonMoves MyFourthMove = MyPokemon.MovesICanUse[3];
            NameMove4.text = MyPokemon.MovesICanUse[3].Name;
        }
        else
        {
            PokemonMoves MyFourthMove = MyPokemon.MovesICanUse[3];
            NameMove4.text = "Empty";
        }
    }
    public void Item()
    {
        FightMenu.SetActive(false);
        FightItem.SetActive(true);
    }
    public void ChangePokemon()
    {
        FightMenu.SetActive(false);
        FightChangePokemon.SetActive(true);

        IconPoke1.sprite = Pokemon1.icon;
        IconPoke2.sprite = Pokemon2.icon;
        IconPoke3.sprite = Pokemon3.icon;
        IconPoke4.sprite = Pokemon4.icon;
        IconPoke5.sprite = Pokemon5.icon;
        IconPoke6.sprite = Pokemon6.icon;

        NamePoke1.text = Pokemon1.Name;
        NamePoke2.text = Pokemon2.Name;
        NamePoke3.text = Pokemon3.Name;
        NamePoke4.text = Pokemon4.Name;
        NamePoke5.text = Pokemon5.Name;
        NamePoke6.text = Pokemon6.Name;
    }
    public void RunAway()
    {
        CatMove CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        CM.MozeChodzic = true;

        playerCamera.SetActive(true);
        battleCamera.SetActive(false);

        FightMenu.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightItem.SetActive(false);
        FightFIght.SetActive(false);

        //GainEXP(EnemyPokemon.Iconint);

        EnemyPokemon.AttackStat = EnemyPokemon.AttackStatInt;
        EnemyPokemon.DefenceStat = EnemyPokemon.DefenceStatInt;
        EnemyPokemon.SpeedStat = EnemyPokemon.SpeedStatInt;
        EnemyPokemon.maxHP = EnemyPokemon.MaxHpInt;

        SaveBattleEfects();
        

        gm.MyBattlePokemon = Pokemon1;
    }
    public void EndFight()
    {
        CatMove CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        CM.MozeChodzic = true;

        playerCamera.SetActive(true);
        battleCamera.SetActive(false);

        FightMenu.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightItem.SetActive(false);
        FightFIght.SetActive(false);
        
        EnemyPokemon.AttackStat = EnemyPokemon.AttackStatInt;
        EnemyPokemon.DefenceStat = EnemyPokemon.DefenceStatInt;
        EnemyPokemon.SpeedStat = EnemyPokemon.SpeedStatInt;
        EnemyPokemon.maxHP = EnemyPokemon.MaxHpInt;
        EnemyPokemon.HP = EnemyPokemon.HpInt;
        if (wygrana)
        {
            MyPokemon.MyExp += EnemyPokemon.ExpForMe * (1 + EnemyPokemon.level / 5);
        }
        

        if (MyPokemon.HpLossInt >= MyPokemon.maxHP )
        {
            MyPokemon.HP = MyPokemon.maxHP;
            gm.Death();
        }
        SaveBattleEfects();
        Pokemon1.HpLossInt = 0;
        gm.MyBattlePokemon = Pokemon1;

        NoxusMoves.ForKalistaE = 0;

        wygrana = false;
        walka = false;
    }
    public void BackToFightMenu()
    {
        FightMenu.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightItem.SetActive(false);
        FightFIght.SetActive(false);
    }

    public void Atack1()
    {
        if (MyPokemon.MovesICanUse[0] != null)
        {
            int P = Random.Range(1, 99);
            if (MyPokemon.MovesICanUse[0].accuracy - P > 0 && MyPokemon.MovesICanUse[0])
            {
                int o = 0;
                int i = MyPokemon.MovesICanUse[0].MyIndex;
                //Demage(MyPokemon.MovesICanUse[0].MyIndex);
                if (MyPokemon.status == Status.Paranoia)
                {
                    NoxusMoves.MyPokemon = EnemyPokemon;
                    NoxusMoves.EnemyPokemon = MyPokemon;
                }
                NoxusMoves.NoxusMovess[i]();
                StartCoroutine(MyAttackLog(true, o));
                PokeInfo.ShowInfoAboutPokemon();
            }
            else if ((MyPokemon.MovesICanUse[0].accuracy - P <= 0))
            {
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy);
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy - P);
                Debug.Log("Nietrafione");
                EnemyTour();
            }
        }
    }

    public void Atack2()
    {
        if (MyPokemon.MovesICanUse[1] != null)
        {
            int P = Random.Range(1, 100);
            if (MyPokemon.MovesICanUse[1].accuracy - P > 0 && MyPokemon.MovesICanUse[1])
            {
                int o = 1;
                int i = MyPokemon.MovesICanUse[1].MyIndex;
                //Demage(MyPokemon.MovesICanUse[1].MyIndex);
                NoxusMoves.NoxusMovess[i]();
                StartCoroutine(MyAttackLog(true, o));
                PokeInfo.ShowInfoAboutPokemon();
            }
            else if ((MyPokemon.MovesICanUse[0].accuracy - P <= 0))
            {
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy);
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy - P);
                Debug.Log("Nietrafione");
                EnemyTour();
            }
        }
    }

    public void Atack3()
    {
        if (MyPokemon.MovesICanUse[2] != null)
        {
            int P = Random.Range(1, 100);
            if (MyPokemon.MovesICanUse[2].accuracy - P > 0 && MyPokemon.MovesICanUse[2])
            {
                int o = 2;
                int i = MyPokemon.MovesICanUse[2].MyIndex;
                //Demage(MyPokemon.MovesICanUse[2].MyIndex);
                NoxusMoves.NoxusMovess[i]();
                StartCoroutine(MyAttackLog(true, o));
                PokeInfo.ShowInfoAboutPokemon();
            }
            else if ((MyPokemon.MovesICanUse[0].accuracy - P <= 0))
            {
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy);
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy - P);
                Debug.Log("Nietrafione");
                EnemyTour();
            }
        }
    }

    public void Atack4()
    {
        if (MyPokemon.MovesICanUse[3] != null)
        {
            int P = Random.Range(1, 100);
            if (MyPokemon.MovesICanUse[3].accuracy - P > 0 && MyPokemon.MovesICanUse[3])
            {
                int o = 3;
                int i = MyPokemon.MovesICanUse[3].MyIndex;
                //Demage(MyPokemon.MovesICanUse[3].MyIndex);
                NoxusMoves.NoxusMovess[i]();
                StartCoroutine(MyAttackLog(true, o));
                PokeInfo.ShowInfoAboutPokemon();
            }
            else if ((MyPokemon.MovesICanUse[0].accuracy - P <= 0))
            {
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy);
                Debug.Log(MyPokemon.MovesICanUse[0].accuracy - P);
                Debug.Log("Nietrafione");
                EnemyTour();
            }
        }
    }
    public void ChangePoke1()
    {
        if(Pokemon1.Name != "Nothing" && Pokemon1.HP > 0)
        {
            SaveBattleEfects();
            gm.MyBattlePokemon = Pokemon1;
            gm.SpawnMyPokemon(Pokemon1);
            StartCoroutine(ChangePokemon(true));
            PokeInfo.ShowInfoAboutPokemon();
            TourNumber++;
        }
    }
    public void ChangePoke2()
    {
        if (Pokemon2.Name != "Nothing" && Pokemon2.HP > 0)
        {
            SaveBattleEfects();
            gm.MyBattlePokemon = Pokemon2;
            gm.SpawnMyPokemon2(Pokemon2);
            StartCoroutine(ChangePokemon(true));
            PokeInfo.ShowInfoAboutPokemon();
            TourNumber++;
        }
    }
    public void ChangePoke3()
    {
        if (Pokemon3.Name != "Nothing" && Pokemon2.HP > 0)
        {
            SaveBattleEfects();
            gm.MyBattlePokemon = Pokemon3;
            gm.SpawnMyPokemon3(Pokemon3);
            StartCoroutine(ChangePokemon(true));
            PokeInfo.ShowInfoAboutPokemon();
            TourNumber++;
        }
    }
    public void ChangePoke4()
    {
        if (Pokemon4.Name != "Nothing" && Pokemon4.HP > 0)
        {
            SaveBattleEfects();
            gm.MyBattlePokemon = Pokemon4;
            gm.SpawnMyPokemon(Pokemon4);
            StartCoroutine(ChangePokemon(true));
            PokeInfo.ShowInfoAboutPokemon();
            TourNumber++;
        }
    }
    public void ChangePoke5()
    {
        if (Pokemon5.Name != "Nothing" && Pokemon5.HP > 0)
        {
            SaveBattleEfects();
            gm.MyBattlePokemon = Pokemon5;
            gm.SpawnMyPokemon(Pokemon5);
            StartCoroutine(ChangePokemon(true));
            PokeInfo.ShowInfoAboutPokemon();
            TourNumber++;
        }
    }
    public void ChangePoke6()
    {
        if (Pokemon6.Name != "Nothing" && Pokemon6.HP > 0)
        {
            SaveBattleEfects();
            gm.MyBattlePokemon = Pokemon6;
            gm.SpawnMyPokemon(Pokemon6);
            StartCoroutine(ChangePokemon(true));
            PokeInfo.ShowInfoAboutPokemon();
            TourNumber++;
        }
    }

    public void SaveBattleEfects()
    {
        if (MyPokemon.Name == Pokemon1.Name)
        {
            Pokemon1.HpLossInt = MyPokemon.maxHP - MyPokemon.HP;
            Pokemon1.HP = MyPokemon.HP;
            Pokemon1.AttackStat = MyPokemon.AttackStatInt;
            Pokemon1.DefenceStat = MyPokemon.DefenceStatInt;
            Pokemon1.SpeedStat = MyPokemon.SpeedStatInt;
            Pokemon1.maxHP = MyPokemon.MaxHpInt;
            Pokemon1.MyExp = MyPokemon.MyExp;
            
            
        }
        if (MyPokemon.Name == Pokemon2.Name)
        {
            Pokemon2.HpLossInt = MyPokemon.maxHP - MyPokemon.HP;
            Pokemon2.HP = MyPokemon.HP;
            Pokemon2.AttackStat = MyPokemon.AttackStatInt;
            Pokemon2.DefenceStat = MyPokemon.DefenceStatInt;
            Pokemon2.SpeedStat = MyPokemon.SpeedStatInt;
            Pokemon2.maxHP = MyPokemon.MaxHpInt;
            Pokemon2.MyExp = MyPokemon.MyExp;
        }
        if (MyPokemon.Name == Pokemon3.Name)
        {
            Pokemon3.HpLossInt = MyPokemon.maxHP - MyPokemon.HP;
            Pokemon3.HP = MyPokemon.HP;
            Pokemon3.AttackStat = MyPokemon.AttackStatInt;
            Pokemon3.DefenceStat = MyPokemon.DefenceStatInt;
            Pokemon3.SpeedStat = MyPokemon.SpeedStatInt;
            Pokemon3.maxHP = MyPokemon.MaxHpInt;
            Pokemon3.MyExp = MyPokemon.MyExp;
        }
        if (MyPokemon.Name == Pokemon4.Name)
        {
            Pokemon4.HpLossInt = MyPokemon.maxHP - MyPokemon.HP;
            Pokemon4.HP = MyPokemon.HP;
            Pokemon4.AttackStat = MyPokemon.AttackStatInt;
            Pokemon4.DefenceStat = MyPokemon.DefenceStatInt;
            Pokemon4.SpeedStat = MyPokemon.SpeedStatInt;
            Pokemon4.maxHP = MyPokemon.MaxHpInt;
            Pokemon4.MyExp = MyPokemon.MyExp;
        }
        if (MyPokemon.Name == Pokemon5.Name)
        {
            Pokemon5.HpLossInt = MyPokemon.maxHP - MyPokemon.HP;
            Pokemon5.HP = MyPokemon.HP;
            Pokemon5.AttackStat = MyPokemon.AttackStatInt;
            Pokemon5.DefenceStat = MyPokemon.DefenceStatInt;
            Pokemon5.SpeedStat = MyPokemon.SpeedStatInt;
            Pokemon5.maxHP = MyPokemon.MaxHpInt;
            Pokemon5.MyExp = MyPokemon.MyExp;
        }
        if (MyPokemon.Name == Pokemon6.Name)
        {
            Pokemon6.HpLossInt = MyPokemon.maxHP - MyPokemon.HP;
            Pokemon6.HP = MyPokemon.HP;
            Pokemon6.AttackStat = MyPokemon.AttackStatInt;
            Pokemon6.DefenceStat = MyPokemon.DefenceStatInt;
            Pokemon6.SpeedStat = MyPokemon.SpeedStatInt;
            Pokemon6.maxHP = MyPokemon.MaxHpInt;
            Pokemon6.MyExp = MyPokemon.MyExp;
        }
        /*
        EnemyPokemon.AttackStat = EnemyPokemon.AttackStatInt;
        EnemyPokemon.SpAttackStat = EnemyPokemon.SpAttackStatInt;
        EnemyPokemon.DefenceStat = EnemyPokemon.DefenceStatInt;
        EnemyPokemon.SpDefenceStat = EnemyPokemon.SpDefenceStatInt;
        EnemyPokemon.SpeedStat = EnemyPokemon.SpeedStatInt;
        EnemyPokemon.maxHP = EnemyPokemon.MaxHpInt;
        */
    }

    public void EnemyTour()
    {
        PokemonScript Poke = NoxusMoves.MyPokemon;
        PokemonScript Poke2 = NoxusMoves.EnemyPokemon;
        if (EnemyPokemon.status != Status.Paranoia)
        {
            NoxusMoves.MyPokemon = Poke2;
            NoxusMoves.EnemyPokemon = Poke;
        }
        else
        {
            NoxusMoves.MyPokemon = Poke;
            NoxusMoves.EnemyPokemon = Poke2;
        }

        int i = Random.RandomRange(0, 3);
        NoxusMoves.NoxusMovess[EnemyPokemon.MovesICanUse[i].MyIndex]();

        StartCoroutine(EnemyAttackLog(true, i));
        //StartCoroutine(MyAttackLog(true, (i)));
        PokeInfo.ShowInfoAboutPokemon();

        NoxusMoves.MyPokemon = Poke;
        NoxusMoves.EnemyPokemon = Poke2;
    }
    public void Effect(PokemonScript Pokemon)
    {
        if (Pokemon.status == Status.Bleeding)
        {
            Pokemon.HP -= (int)(Pokemon.maxHP/10);
            LogText.text = Pokemon.Name + " is bleeding and lost "+Pokemon.maxHP / 10+"HP!";
        }
        if (Pokemon.status == Status.Poisoned)
        {
            Pokemon.HP -= (int)(Pokemon.maxHP / 10);
            LogText.text = Pokemon.Name + " is poisoned lost " + Pokemon.maxHP / 10 + "HP!";
        }
    }
    public void RegionEffect(PokemonScript Pokemon, PokemonScript Enemy)
    {
        LOG.SetActive(true);
        FightChangePokemon.SetActive(false);
        FightFIght.SetActive(false);
        FightItem.SetActive(false);
        FightMenu.SetActive(false);
        MyInfo.SetActive(false);
        EnemyInfo.SetActive(false);
        FightUI.SetActive(false);
        if (Pokemon.type == PokemonType.Noxus)
        {
            Pokemon.AttackStat += 3;
            LogText.text = Pokemon.Name + " got bonus from his region";
        }
        if (Pokemon.type == PokemonType.Void)
        {
            Enemy.HP -= 2;
            LogText.text = Enemy.Name + " lost 2HP becouse of " + Pokemon.Name + " region";
        }
        if (Pokemon.type == PokemonType.Shadow_Isles && Enemy.type != PokemonType.Shadow_Isles)
        {
            LogText.text = (10 - TourNumber) + " tour more and you will win!";
            if (TourNumber == 9)
            {
                EnemyPokemon.HP = -100;
            }
        }
        else if (Pokemon.type == PokemonType.Shadow_Isles && Enemy.type == PokemonType.Shadow_Isles)
        {
            LogText.text = "You and enemy are from Shadow Isles so region bonus doasn't work";
        }
    }
    public void RegionEffectEnemy(PokemonScript Pokemon, PokemonScript Enemy)
    {
        if (Enemy.type == PokemonType.Noxus)
        {
            Enemy.AttackStat += 3;
            LogText.text = Enemy.Name + " got bonus from his region";
        }
        if (Enemy.type == PokemonType.Void)
        {
            Pokemon.HP -= 2;
            LogText.text = Pokemon.Name + " lost 2HP becouse of " + Enemy.Name + " region";
        }
        if (Enemy.type == PokemonType.Shadow_Isles && Pokemon.type != PokemonType.Shadow_Isles)
        {
            LogText.text = (10 - TourNumber) + " tour more and enemy will win!";
            if (TourNumber == 9)
            {
                Pokemon.HP = -100;
            }

        }

    }
    private void SceneReset()
    {
        Demacia.SetActive(false);
        Piltover.SetActive(false);
        PokeScene.SetActive(false);
        Ionia.SetActive(false);
        Noxus.SetActive(false);
        Void.SetActive(false);
        BandleCity.SetActive(false);
        ShadowIsles.SetActive(false);
        Shurima.SetActive(false);
        Freljord.SetActive(false);
        Zaun.SetActive(false);
        Bilgewater.SetActive(false);
        Targon.SetActive(false);

        if (EnemyPokemon.type.ToString() == "Ionia")
        {
            Ionia.SetActive(true);
        }else if (EnemyPokemon.type.ToString() == "Noxus")
        {
            Noxus.SetActive(true);
        }
        else if(EnemyPokemon.type.ToString() == "Void")
        {
            Void.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Targon")
        {
            Targon.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Zaun")
        {
            Zaun.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Piltover")
        {
            Piltover.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Freljord")
        {
            Freljord.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Demacia")
        {
            Demacia.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Bandle_City")
        {
            BandleCity.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Shadow_Isles")
        {
            ShadowIsles.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Bilgewater")
        {
            Bilgewater.SetActive(true);
        }
        else if (EnemyPokemon.type.ToString() == "Shurima")
        {
            Shurima.SetActive(true);
        }
    }

    public void Demage(int index)
    {
        int crit;
        int CritChance = Random.RandomRange(1, 100);
        if (CritChance <= 15)
        {
            crit = 2;
        }
        else
        {
            crit = 1;
        }
        demage = (((((2 * MyPokemon.level) / 5) * gm.AllMoves[index].power * MyPokemon.AttackStat / EnemyPokemon.DefenceStat) / 5) + 2) * crit;

    }

    public void GainEXP(int i)
    {
        int b = gm.AllPokemon[i].ExpForMe;
        int l = EnemyPokemon.level;
        Exp = (a * b * l) / 7;
        print(a);
        print(l);
        print(b);
        print(gm.AllPokemon[i].Name);
        print(gm.AllPokemon[0].Name);
        MyPokemon.MyExp += Exp;
    }
    public void CheckLevel(PokemonScript Pokemon)
    {
        int MyLevel;
        int OldLevel = Pokemon.level;
        for (int i = 0; i < 100; i++)
        {
            if ((i * i * i) > Pokemon.MyExp)
            {
                MyLevel = i - 1;
                print(MyLevel + " level");
                Pokemon.level = MyLevel;
                break;
            }
        }
    }
    public void MoneyForWin()
    {
        int P = Random.Range(1, 5);
        AmountOfMoney += (P+5)*EnemyPokemon.level;
        MoneyText.text = AmountOfMoney.ToString();
    }
}
