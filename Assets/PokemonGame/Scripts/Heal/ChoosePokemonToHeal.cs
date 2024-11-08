using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePokemonToHeal : MonoBehaviour
{
    [SerializeField]
    public GameObject menu;
    public Image IPoke1;
    public Image IPoke2;
    public Image IPoke3;
    public Image IPoke4;
    public Image IPoke5;
    public Image IPoke6;
    public PokemonScript Poke1;
    public PokemonScript Poke2;
    public PokemonScript Poke3;
    public PokemonScript Poke4;
    public PokemonScript Poke5;
    public PokemonScript Poke6;

    private MyPokemon MP;
    private BattleManager BM;
    private GameObject Space;

    private Vector3 scaleChange;
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
    }

    // Update is called once per frame
    public void Awake()
    {
        Poke1 = GameObject.FindGameObjectWithTag("First").GetComponent<PokemonScript>();
        Poke2 = GameObject.FindGameObjectWithTag("Second").GetComponent<PokemonScript>();
        Poke3 = GameObject.FindGameObjectWithTag("Third").GetComponent<PokemonScript>();
        Poke4 = GameObject.FindGameObjectWithTag("Fourth").GetComponent<PokemonScript>();
        Poke5 = GameObject.FindGameObjectWithTag("Fiveth").GetComponent<PokemonScript>();
        Poke6 = GameObject.FindGameObjectWithTag("Sixth").GetComponent<PokemonScript>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        Space = GameObject.FindGameObjectWithTag("Canvas");
        //Instantiate(menu, gameObject.transform.position, Quaternion.identity);
        gameObject.transform.parent = Space.transform;
        scaleChange = new Vector3(1f, 1f, 1f);
        gameObject.transform.localScale = scaleChange;
        Active();
    }
    public void HealPoke1()
    {
        Poke1 = GameObject.FindGameObjectWithTag("First").GetComponent<PokemonScript>();
        Poke2 = GameObject.FindGameObjectWithTag("Second").GetComponent<PokemonScript>();
        Poke3 = GameObject.FindGameObjectWithTag("Third").GetComponent<PokemonScript>();
        Poke4 = GameObject.FindGameObjectWithTag("Fourth").GetComponent<PokemonScript>();
        Poke5 = GameObject.FindGameObjectWithTag("Fiveth").GetComponent<PokemonScript>();
        Poke6 = GameObject.FindGameObjectWithTag("Sixth").GetComponent<PokemonScript>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        Poke1.HpLossInt -= 20;
        if (Poke1.HpLossInt < 0)
        {
            Poke1.HpLossInt = 0;
        }
        Destroy(GameObject.Find("ChoosePokemonToHeal" + "(Clone)"));
    }
    public void Active()
    {
        menu.SetActive(true);
        IPoke1.sprite = Poke1.icon;
        IPoke2.sprite = Poke2.icon;
        IPoke3.sprite = Poke3.icon;
        IPoke4.sprite = Poke4.icon;
        IPoke5.sprite = Poke5.icon;
        IPoke6.sprite = Poke6.icon;
    }
}
