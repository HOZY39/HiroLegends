using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokemonPlayer : MonoBehaviour
{
    public List<OwnedPokemon> ownedPokemon = new List<OwnedPokemon>();
}

[System.Serializable]
public class OwnedPokemon
{
    public string NickName;
    public PokemonScript pokemon;
    public int level;
}