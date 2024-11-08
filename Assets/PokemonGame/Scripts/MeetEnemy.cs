using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetEnemy : MonoBehaviour
{
    private PokemonGameManager gm;

    private BattleManager BM;

    private InfoAboutPokemon Info;

    private CatMove CM;
    private PokemonScript Poke;

    private GameObject Catch;
    private Dialog DMan;
    public string CoPowiedziec1;
    public string CoPowiedziec2;
    public string CoPowiedziec3;
    public int ID;
    public int level;
    private GameObject RunAway;
    // Start is called before the first frame update
    void Start()
    {
        Poke = GameObject.FindGameObjectWithTag("First").GetComponent<PokemonScript>();
        DMan = FindObjectOfType<Dialog>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        Info = GameObject.FindGameObjectWithTag("Info").GetComponent<InfoAboutPokemon>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        //Catch = GameObject.FindGameObjectWithTag("Catch");
        RunAway = GameObject.FindGameObjectWithTag("RunAway");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CM.MozeChodzic = false;
            RunAway.SetActive(false);
            DMan.ShowBox(CoPowiedziec1);
            StartCoroutine("Enemy", true);
        }
    }
    IEnumerator Enemy(bool wait)
    {
        bool win = false;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                //Catch.SetActive(false);
                SpawnEnemy();
                wait = false;
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) && BM.walka == false)
            {
                if (BM.MyPokemon.HP <= 0)
                {
                    Debug.Log("benc po ");
                    DMan.dialogAktywacja = true;
                    DMan.dBox.SetActive(true);
                    DMan.dText.text = CoPowiedziec2;
                    win = false;
                    yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
                    yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
                    yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
                    yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
                    gm.Death();
                    wait = false;
                }
                else
                {
                    Debug.Log("benc po ");
                    DMan.dialogAktywacja = true;
                    DMan.dBox.SetActive(true);
                    DMan.dText.text = CoPowiedziec3;
                    win = true;
                    wait = false;
                }
            }
            yield return null;
        }
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        Debug.Log("benc");
        DMan.dBox.SetActive(false);
        DMan.dialogAktywacja = false;
        if (win)
        {
            gameObject.SetActive(false);
        }
        /*
        wait = true;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("benc");
                StartCoroutine("Skip", true);
                if (win)
                {
                    gameObject.SetActive(false);
                }
                wait = false;
            }
            yield return null;
        }
        */
        RunAway.SetActive(true);
        //Catch.SetActive(true);
        //Catch.SetActive(false);
    }
    IEnumerator Skip(bool wait)
    {
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                DMan.dBox.SetActive(false);
                DMan.dialogAktywacja = false;
                wait = false;
            }
            yield return null;
        }
    }
    void SpawnEnemy()
    {
        gm.SpawnEnemy(ID);
        gm.emptyPoke.level = level;
        for (int i = 1; i <= gm.emptyPoke.level - 1; i++)
        {
            gm.emptyPoke.PokemonLevelUp();
        }


        gm.SpawnMyPokemon(Poke);


        BM.StartFight();
        Info.ShowInfoAboutPokemon();
    }
}
