using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonLongGrass : MonoBehaviour
{
    private PokemonGameManager gm;

    private BattleManager BM;

    private PokemonScript Poke;

    private InfoAboutPokemon Info;
    public PokemonRarity rarity;
    public PokemonType region;

    private SpriteRenderer mySpriteRenderer;

    public PokemonScript MyPokemon;

    public int MaxLevel;
    public int MinLevel;
    

    public List<int> ID = new List<int>();

    private int WhatPoke;
    private int EnemyPokeLevel;
    public RegenAfterSomeTime Daddy;
    public int CD;

    void Start()
    {
        Poke = GameObject.FindGameObjectWithTag("First").GetComponent<PokemonScript>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        Info = GameObject.FindGameObjectWithTag("Info").GetComponent<InfoAboutPokemon>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        /*
        WhatPoke = Random.Range(0, ID.Count - 1);
        EnemyPokeLevel = Random.Range(MinLevel, MaxLevel);
        mySpriteRenderer.sprite = gm.AllPokemon[ID[WhatPoke]].sprite;
        */
    }
    void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        WhatPoke = Random.Range(0, ID.Count - 1);
        EnemyPokeLevel = Random.Range(MinLevel, MaxLevel);
        mySpriteRenderer.sprite = gm.AllPokemon[ID[WhatPoke]].sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            int Los = Random.Range(0, 10);
            if (Los >= 0)
            {
                gm.SpawnEnemy(ID[WhatPoke]);
                gm.emptyPoke.level = EnemyPokeLevel+1;
                for (int i = 1; i <= gm.emptyPoke.level - 1; i++)
                {
                    gm.emptyPoke.PokemonLevelUp();
                }
                gm.emptyPoke.MyExp = gm.emptyPoke.level * gm.emptyPoke.level * gm.emptyPoke.level;


                gm.SpawnMyPokemon(Poke);


                BM.StartFight();
                Info.ShowInfoAboutPokemon();
            }
            Daddy.Regen(CD);
            gameObject.SetActive(false);
        }
    }
}
