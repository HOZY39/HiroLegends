using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonGameManager : MonoBehaviour
{
    
    public GameObject playerCamera;
    public GameObject battleCamera;
    public PokemonScript emptyPoke;
    public PokemonScript emptyPoke2;
    public PokemonScript MyBattlePokemon;
    private Dialog DMan;

    public GameObject player;

    public List<PokemonScript> AllPokemon = new List<PokemonScript>();
    public List<PokemonMoves> AllMoves = new List<PokemonMoves>();

    public Transform defencePodium;
    public Transform attackPodium;

    public GameObject Menu;
    public GameObject Info;

    public PokemonMoves PM;

    private BattleManager BM;

    public GameObject PC;

    public string NamePlayer;
    public int FirstPartnerID;

    void Start()
    {
        DMan = FindObjectOfType<Dialog>();
        playerCamera.SetActive(true);
        battleCamera.SetActive(false);
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        NamePlayer = NameAndPartner.Name;
        FirstPartnerID = NameAndPartner.PartnerID -1;
    }

    // Update is called once per frame

    public GameObject NameObject;
    //public GameObject display;
    public void Name()
    {
        NamePlayer = NameAndPartner.Name;
        //display.GetComponent<Text>().text = "Hi, " + MyNick;
        NameObject.SetActive(false);
        CatMove CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        CM.MozeChodzic = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Menu.active == false)
            {
                Menu.SetActive(true);
            }
            else
            {
                Menu.SetActive(false);
            }
        }
    }
    public void MenuEsc()
    {
        if (Menu.active == false)
        {
            Menu.SetActive(true);
        }
        else
        {
            Menu.SetActive(false);
        }
    }
    public void InfoEsc()
    {
        if (Info.active == false)
        {
            Info.SetActive(true);
        }
        else
        {
            Info.SetActive(false);
        }
    }
    public void SpawnEnemy(int ID)
    {
        playerCamera.SetActive(false);
        battleCamera.SetActive(true);

        PokemonScript battlePokemon = GetPokemonByID(ID);

        emptyPoke.transform.parent = defencePodium;

        emptyPoke.AddMember(battlePokemon);
        for (int i = 0; i < 4; i++)
        {
            int random = Random.Range(2, 21);
            AddMove(random, emptyPoke);
            print("add move");
        }

        emptyPoke.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }

    public void Death()
    {
        player.transform.position = new Vector3(0f, 14f, 100f);
        //StartCoroutine("PoZgonie", true);
    }


    public void SpawnKonkretnyEnemy(PokemonScript Pokus)
    {
        playerCamera.SetActive(false);
        battleCamera.SetActive(true);

        PokemonScript battlePokemon = Pokus;

        emptyPoke.transform.parent = defencePodium;

        emptyPoke.AddMember(battlePokemon);

        emptyPoke.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }
    IEnumerator PoZgonie(bool wait)
    {
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                string CoPowiedziec = "Uważaj na siebie następnym razem dobrze?";
                DMan.RShowBox(CoPowiedziec);
                wait = false;
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                string CoPowiedziec = "Uleczyłam dla Ciebie twojego bohatera! owo uwu";
                DMan.RShowBox(CoPowiedziec);
                wait = false;
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                DMan.HideBox(); ;
                wait = false;
            }
            yield return null;
        }

    }
    public void SpawnMyPokemon(PokemonScript Poke)
    {
        
        BM.CheckLevel(Poke);
        for (int i = 1; i <= BM.Pokemon1.level - 1; i++)
        {
            BM.Pokemon1.PokemonLevelUp();
        }
        BM.Pokemon1.HP = BM.Pokemon1.maxHP;
        BM.Pokemon1.HP -= BM.Pokemon1.HpLossInt;

        PokemonScript battlePokemon = MyBattlePokemon;
        
        emptyPoke2.transform.parent = attackPodium;

        emptyPoke2.AddMember(battlePokemon);

        emptyPoke2.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }
    public void SpawnMyPokemon2(PokemonScript Poke)
    {

        BM.CheckLevel(Poke);
        for (int i = 1; i <= BM.Pokemon2.level - 1; i++)
        {
            BM.Pokemon2.PokemonLevelUp();
        }
        BM.Pokemon2.HP = BM.Pokemon2.maxHP;
        BM.Pokemon2.HP -= BM.Pokemon2.HpLossInt;

        PokemonScript battlePokemon = MyBattlePokemon;

        emptyPoke2.transform.parent = attackPodium;

        emptyPoke2.AddMember(battlePokemon);

        emptyPoke2.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }
    public void SpawnMyPokemon3(PokemonScript Poke)
    {

        BM.CheckLevel(Poke);
        for (int i = 1; i <= BM.Pokemon3.level - 1; i++)
        {
            BM.Pokemon3.PokemonLevelUp();
        }
        BM.Pokemon3.HP = BM.Pokemon3.maxHP;
        BM.Pokemon3.HP -= BM.Pokemon3.HpLossInt;

        PokemonScript battlePokemon = MyBattlePokemon;

        emptyPoke2.transform.parent = attackPodium;

        emptyPoke2.AddMember(battlePokemon);

        emptyPoke2.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }
    public void SpawnMyPokemon4(PokemonScript Poke)
    {

        BM.CheckLevel(Poke);
        for (int i = 1; i <= BM.Pokemon4.level - 1; i++)
        {
            BM.Pokemon4.PokemonLevelUp();
        }
        BM.Pokemon4.HP = BM.Pokemon4.maxHP;
        BM.Pokemon4.HP -= BM.Pokemon4.HpLossInt;

        PokemonScript battlePokemon = MyBattlePokemon;

        emptyPoke2.transform.parent = attackPodium;

        emptyPoke2.AddMember(battlePokemon);

        emptyPoke2.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }
    public void SpawnMyPokemon5(PokemonScript Poke)
    {

        BM.CheckLevel(Poke);
        for (int i = 1; i <= BM.Pokemon5.level - 1; i++)
        {
            BM.Pokemon5.PokemonLevelUp();
        }
        BM.Pokemon5.HP = BM.Pokemon5.maxHP;
        BM.Pokemon5.HP -= BM.Pokemon5.HpLossInt;

        PokemonScript battlePokemon = MyBattlePokemon;

        emptyPoke2.transform.parent = attackPodium;

        emptyPoke2.AddMember(battlePokemon);

        emptyPoke2.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }
    public void SpawnMyPokemon6(PokemonScript Poke)
    {

        BM.CheckLevel(Poke);
        for (int i = 1; i <= BM.Pokemon6.level - 1; i++)
        {
            BM.Pokemon6.PokemonLevelUp();
        }
        BM.Pokemon6.HP = BM.Pokemon6.maxHP;
        BM.Pokemon6.HP -= BM.Pokemon6.HpLossInt;

        PokemonScript battlePokemon = MyBattlePokemon;

        emptyPoke2.transform.parent = attackPodium;

        emptyPoke2.AddMember(battlePokemon);

        emptyPoke2.GetComponent<SpriteRenderer>().sprite = battlePokemon.sprite;

    }

    public PokemonScript GetRandomPokemonFromList(List<PokemonScript> pokeList)
    {
        PokemonScript poke = new PokemonScript();
        int pokeIndex = Random.Range(0, pokeList.Count - 1);
        poke = pokeList[pokeIndex];
        return poke;
    }

    public List<PokemonScript> GetPokemonByRarity(PokemonRarity rarity)
    {
        List<PokemonScript> returnPokemon = new List<PokemonScript>();
        foreach (PokemonScript Pokemon in AllPokemon)
        {
            if (Pokemon.rarity == rarity)
                returnPokemon.Add(Pokemon);
        }

        return returnPokemon;
    }
    public List<PokemonScript> GetPokemonByRegion(PokemonType region)
    {
        List<PokemonScript> returnPokemon = new List<PokemonScript>();
        foreach (PokemonScript Pokemon in AllPokemon)
        {
            if (Pokemon.type == region)
                returnPokemon.Add(Pokemon);
        }

        return returnPokemon;
    }
    PokemonScript GetPokemonByID(int ID)
    {
        /*
        List<PokemonScript> returnPokemon = new List<PokemonScript>();
        foreach (PokemonScript Pokemon in AllPokemon)
        {
            if (Pokemon.Iconint == ID && Pokemon.Iconint == ID)
                returnPokemon.Add(Pokemon);
        }
        */
        PokemonScript poke = AllPokemon[ID];

        return poke;
    }
    public List<PokemonScript> GetPokemonByName(string name)
    {
        List<PokemonScript> returnPokemon = new List<PokemonScript>();
        foreach (PokemonScript Pokemon in AllPokemon)
        {
            if (Pokemon.Name == name)
                returnPokemon.Add(Pokemon);
        }

        return returnPokemon;
    }



    public List<PokemonMoves> GetMoveByName(string name)
    {
        List<PokemonMoves> returnMove = new List<PokemonMoves>();
        foreach (PokemonMoves Move in AllMoves)
        {
            if (Move.Name == name)
                returnMove.Add(Move);
        }

        return returnMove;
    }



    public void AddMove(int PokeMove, PokemonScript bp)
    {
        if (bp.MovesICanUse[0] == AllMoves[0])
        {
            bp.MovesICanUse[0] = AllMoves[PokeMove];
            bp.MovesICanUse1Int = PokeMove;
        }
        else if (bp.MovesICanUse[1] == AllMoves[0])
        {
            bp.MovesICanUse[1] = AllMoves[PokeMove];
            bp.MovesICanUse2Int = PokeMove;
        }
        else if (bp.MovesICanUse[2] == AllMoves[0])
        {
            bp.MovesICanUse[2] = AllMoves[PokeMove];
            bp.MovesICanUse3Int = PokeMove;
        }
        else if (bp.MovesICanUse[3] == AllMoves[0])
        {
            bp.MovesICanUse[3] = AllMoves[PokeMove];
            bp.MovesICanUse4Int = PokeMove;
        }
        else
        {
            Debug.Log(bp.MovesICanUse[0].Name);
            Debug.Log(AllMoves[0].Name);
            Debug.Log(AllMoves[PokeMove].moveType);
            Debug.Log(bp.type);
            Debug.Log("Max nauczonych ruchów lub pokemon nie moze sie go nauczyc");
        }
    }
}