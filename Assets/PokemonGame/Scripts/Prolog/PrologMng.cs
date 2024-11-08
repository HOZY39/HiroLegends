using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologMng : MonoBehaviour
{
    private Dialog DMan;
    private MyPokemon MP;
    public string CoPowiedziec;
    public Npc ZlaKobieta;
    public Npc ZlyFacet;
    public GameObject ZlyFacetPr;
    public GameObject ZlaKobietaPr;
    public GameObject TataPr;
    public GameObject Przejscie;
    public GameObject player;
    public FIrstPokemon Tata;
    private GameObject Catch;
    private GameObject RunAway;
    private CatMove CM;
    public GameObject Mur;
    public GameObject MamaDialog1;
    public GameObject MamaDialog2;
    public List<string> CoMowicRozbite = new List<string>();

    private void Start()
    {
        DMan = FindObjectOfType<Dialog>();
        CM = GameObject.FindGameObjectWithTag("Player").GetComponent<CatMove>();
        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
        Catch = GameObject.FindGameObjectWithTag("Catch");
        RunAway = GameObject.FindGameObjectWithTag("RunAway");
    }
    public void Zli1()
    {
        StartCoroutine(ZliIdaDoTaty());

    }
    IEnumerator ZliIdaDoTaty(bool wait = true)
    {
        //player.transform.position = new Vector3(-143, -94f, 0);
        ZlyFacetPr.SetActive(true);
        ZlaKobietaPr.SetActive(true);
        ZlaKobieta.Left = true;
        ZlyFacet.Left = true;
        yield return new WaitUntil(() => ZlaKobieta.transform.position.x <= Tata.transform.position.x -1 || ZlyFacet.transform.position.x <= Tata.transform.position.x + 1);
        if (ZlaKobieta.transform.position.x <= Tata.transform.position.x - 1)
        {
            ZlaKobieta.Left = false;
            yield return new WaitUntil(() => ZlyFacet.transform.position.x <= Tata.transform.position.x + 1);
            ZlyFacet.Left = false;
        }
        else
        {
            ZlyFacet.Left = false;
            yield return new WaitUntil(() => ZlaKobieta.transform.position.x <= Tata.transform.position.x - 1);
            ZlaKobieta.Left = false;
        }
        ZlaKobieta.Down = true;
        ZlyFacet.Down = true;
        yield return new WaitUntil(() => ZlaKobieta.transform.position.y <= Tata.transform.position.y || ZlyFacet.transform.position.y <= Tata.transform.position.y);
        if (ZlaKobieta.transform.position.x <= Tata.transform.position.y)
        {
            ZlaKobieta.Down = false;
            yield return new WaitUntil(() => ZlyFacet.transform.position.y <= Tata.transform.position.y);
            ZlyFacet.Down = false;
        }
        else
        {
            ZlyFacet.Down = false;
            yield return new WaitUntil(() => ZlaKobieta.transform.position.y <= Tata.transform.position.y);
            ZlaKobieta.Down = false;
        }


        CoPowiedziec = CoMowicRozbite[0];
        DMan.RShowBox(CoPowiedziec);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        CoPowiedziec = CoMowicRozbite[1];
        DMan.RShowBox(CoPowiedziec);
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        CoPowiedziec = CoMowicRozbite[2];
        DMan.RShowBox(CoPowiedziec);
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        DMan.HideBox();
        CM.PokeChange();
        ZlyFacetPr.SetActive(false);
        ZlaKobietaPr.SetActive(false);
        TataPr.SetActive(false);
        Przejscie.SetActive(true);
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        Przejscie.SetActive(false);
        CM.MozeChodzic = true;
        gameObject.SetActive(false);
        MP.SpaceForMyFirstPokemon.HP = MP.SpaceForMyFirstPokemon.maxHP;
        Catch.SetActive(true);
        RunAway.SetActive(true);
        MamaDialog1.SetActive(false);
        MamaDialog2.SetActive(true);
        Destroy(Mur);
    }
}
