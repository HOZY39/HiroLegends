using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FIrstPokemon : MonoBehaviour
{
    bool GetDraven = false;
    public GameObject player;
    private MyPokemon MP;
    private Dialog DMan;
    private PokemonGameManager gm;
    public PokemonScript MojPokemon;
    private CatMove CM;
    public string CoPowiedziec;
    private BattleManager BM;
    public GameObject Sign;
    public GameObject Choose;
    public GameObject Tutorial;
    public GameObject DialPoWybo;
    public PokemonScript PokemonOjca;
    public PrologMng Prol;
    private InfoAboutPokemon Info;
    public List<string> CoMowicRozbite = new List<string>();
    public List<GameObject> JakWalczyc = new List<GameObject>();
    private GameObject Catch;
    private GameObject RunAway;
    private ButtonHeld ButtonE;
    bool enable = true;
    void Start()
    {
        DMan = FindObjectOfType<Dialog>();
        CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        Info = GameObject.FindGameObjectWithTag("Info").GetComponent<InfoAboutPokemon>();
        Catch = GameObject.FindGameObjectWithTag("Catch");
        RunAway = GameObject.FindGameObjectWithTag("RunAway");
        ButtonE = GameObject.FindGameObjectWithTag("ButtonE").GetComponent<ButtonHeld>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.E) || ButtonE.buttonPressed) && enable)
        {
            CM.MozeChodzic = false;
            if (CoMowicRozbite.Count > 0)
            {
                StartCoroutine(DialogRozbityF(true, 0, 10));
            }
            else
            {
                DMan.ShowBox(CoPowiedziec);
            }
            enable = false;
        }
    }
    public void Champ1()
    {
        MP.AddMyPokemon("Draven");
        MP.SpaceForMyFirstPokemon.MyExp = 125;
        gm.AddMove(2, MP.SpaceForMyFirstPokemon);
        gm.AddMove(14, MP.SpaceForMyFirstPokemon);
        gm.AddMove(15, MP.SpaceForMyFirstPokemon);
        gm.AddMove(17, MP.SpaceForMyFirstPokemon);
        Choose.SetActive(false);
        StartCoroutine(DialogRozbityF(true, 11, 14));
        BM.CheckLevel(MP.SpaceForMyFirstPokemon);
    }
    public void Champ2()
    {
        MP.AddMyPokemon("Maokai");
        MP.SpaceForMyFirstPokemon.MyExp = 125;
        gm.AddMove(18, MP.SpaceForMyFirstPokemon);
        gm.AddMove(19, MP.SpaceForMyFirstPokemon);
        gm.AddMove(20, MP.SpaceForMyFirstPokemon);
        gm.AddMove(21, MP.SpaceForMyFirstPokemon);
        Choose.SetActive(false);
        StartCoroutine(DialogRozbityF(true, 11, 14));
        BM.CheckLevel(MP.SpaceForMyFirstPokemon);
    }
    public void Champ3()
    {
        MP.AddMyPokemon("Kai'sa");
        MP.SpaceForMyFirstPokemon.MyExp = 125;
        gm.AddMove(4, MP.SpaceForMyFirstPokemon);
        gm.AddMove(23, MP.SpaceForMyFirstPokemon);
        gm.AddMove(24, MP.SpaceForMyFirstPokemon);
        gm.AddMove(25, MP.SpaceForMyFirstPokemon);
        Choose.SetActive(false);
        StartCoroutine(DialogRozbityF(true, 11, 14));
        BM.CheckLevel(MP.SpaceForMyFirstPokemon);
    }
    IEnumerator JakWalczycIE(bool wait)
    {
        JakWalczyc[4].SetActive(true);
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                JakWalczyc[1].SetActive(true);
                JakWalczyc[0].SetActive(false);
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
                JakWalczyc[2].SetActive(true);
                JakWalczyc[1].SetActive(false);
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                wait = false;
                JakWalczyc[3].SetActive(true);
                JakWalczyc[2].SetActive(false);
            }
            yield return null;
        }
        JakWalczyc[4].SetActive(false);
    }
    public IEnumerator DialogRozbityF(bool wait, int odkiedy, int koniec)
    {
        for (int i = odkiedy; i <= koniec; i++)
        {
            if (i == 0 || i == 11)
            {
                CoPowiedziec = CoMowicRozbite[i];
                if (i == 11)
                {
                    CoPowiedziec = "O, " + MP.SpaceForMyFirstPokemon.Name + " jest świetnym bohaterem!";
                }
                DMan.RShowBox(CoPowiedziec);
                wait = false;
            }
            if (i == 10)
            {
                Choose.SetActive(true);
            }
            while (wait)
            {
                CM.MozeChodzic = false;
                if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) && i != CoMowicRozbite.Count)
                {
                    CoPowiedziec = CoMowicRozbite[i];
                    DMan.RShowBox(CoPowiedziec);
                    wait = false;
                }
                if ((i == 10 || i == 13 ) && (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
                {
                    DMan.HideBox();
                    wait = false;
                }
                if (i == 18)
                {
                    DMan.HideBox();
                    Prol.Zli1();
                    wait = false;
                }
                if (i==14)
                {
                    gm.SpawnKonkretnyEnemy(PokemonOjca);
                    gm.emptyPoke.level = PokemonOjca.level;
                    for (int j = 1; j <= gm.emptyPoke.level - 1; j++)
                    {
                        gm.emptyPoke.PokemonLevelUp();
                    }
                    gm.SpawnMyPokemon(MojPokemon);
                    Catch.SetActive(false);
                    RunAway.SetActive(false);
                    BM.StartFight();
                    Info.ShowInfoAboutPokemon();
                    StartCoroutine(JakWalczycIE(true));
                    yield return new WaitUntil(() => BM.walka == false);
                    MojPokemon.HP = MojPokemon.maxHP;
                    MojPokemon.HpLossInt = 0;
                    PoWalce();
                    player.transform.position = new Vector3(-143, -94f, 0);
                    wait = false;
                }
                yield return null;
            }
            wait = true;

        }
        print("koniec");
        enable = false;
        GetDraven = false;
    }
    public void PoWalce()
    {
        MojPokemon.HP = MojPokemon.maxHP;
        MojPokemon.HpLossInt = 0;
        StartCoroutine(DialogRozbityF(true, 15, 18));

    }
}
