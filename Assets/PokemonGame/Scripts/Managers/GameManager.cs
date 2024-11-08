using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public GameObject playerCamera;
    public GameObject battleCamera;

    public GameObject player;

    public List<BaseFighter> allPokemon = new List<BaseFighter>();
    public List<PokemonMoves> allMoves = new List<PokemonMoves>();

    public Transform defencePodium;
    public Transform attackPodium;
    public GameObject emptyPoke;

    private InfoAboutPokemon Info;

    void Start()
    {
        playerCamera.SetActive(true);
        battleCamera.SetActive(false);
    }

    void Update()
    {

    }

    public void EnterBattle(Rarity rarity)
    {
        //player.GetComponent<CatMove>().MayMove = false;
        playerCamera.SetActive(false);
        battleCamera.SetActive(true);

        BaseFighter battlePokemon = GetRandomPokemonFromList(GetPokemonByRarity(rarity));

        Debug.Log(battlePokemon.name);


        GameObject dPoke = Instantiate(emptyPoke, defencePodium.transform.position, Quaternion.identity) as GameObject;

        dPoke.transform.parent = defencePodium;

        BaseFighter tempPoke = dPoke.AddComponent<BaseFighter>() as BaseFighter;
        tempPoke.AddMember(battlePokemon);

        dPoke.GetComponent<SpriteRenderer>().sprite = battlePokemon.Image;

    }

    public List<BaseFighter> GetPokemonByRarity(Rarity rarity)
    {
        List<BaseFighter> returnPokemon = new List<BaseFighter>();
        foreach (BaseFighter Pokemon in allPokemon)
        {
            if (Pokemon.rarity == rarity)
                returnPokemon.Add(Pokemon);
        }

        return returnPokemon;
    }

    public BaseFighter GetRandomPokemonFromList(List<BaseFighter> pokeList)
    {
        BaseFighter poke = new BaseFighter();
        int pokeIndex = Random.Range(0, pokeList.Count - 1);
        poke = pokeList[pokeIndex];
        return poke;
    }
}