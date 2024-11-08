using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2Napasc : MonoBehaviour
{
    private PokemonGameManager gm;

    private BattleManager BM;

    private InfoAboutPokemon Info;

    private CatMove CM;
    private PokemonScript Poke;

    private GameObject Catch;
    private Dialog DMan;
    public List<string> CoMowicRozbite = new List<string>();
    public string CoPowiedziec;
    public Npc One;
    public Npc Two;
    public Npc Three;
    public Npc Four;
    public GameObject Napasc;
    // Start is called before the first frame update
    void Start()
    {
        Poke = GameObject.FindGameObjectWithTag("First").GetComponent<PokemonScript>();
        DMan = FindObjectOfType<Dialog>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        Info = GameObject.FindGameObjectWithTag("Info").GetComponent<InfoAboutPokemon>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        Catch = GameObject.FindGameObjectWithTag("Catch");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (CoMowicRozbite.Count > 0)
            {
                CM.MozeChodzic = false;
                StartCoroutine("DialogRozbity2", true);
            }
        }
    }

    IEnumerator DialogRozbity2(bool wait)
    {
        for (int i = 0; i <= CoMowicRozbite.Count; i++)
        {
            if (i == 0)
            {
                CoPowiedziec = CoMowicRozbite[i];
                DMan.RShowBox(CoPowiedziec);
                wait = false;
                print(i);
            }
            while (wait)
            {
                if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) & i != CoMowicRozbite.Count)
                {
                    CoPowiedziec = CoMowicRozbite[i];
                    DMan.RShowBox(CoPowiedziec);
                    wait = false;
                }
                if (i == CoMowicRozbite.Count & (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
                {
                    print("koniec");
                    print(i);
                    print(CoMowicRozbite.Count);
                    DMan.HideBox();
                    wait = false;
                }
                yield return null;
            }
            wait = true;
        }
        One.Right = true;
        Two.Right = true;
        Three.Right = true;
        Four.Right = true;
        yield return new WaitForSeconds(3);
        CM.MozeChodzic = true;
        Destroy(Napasc);
    }
}
