using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public List<OwnedPokemon> ownedPokemon = new List<OwnedPokemon>();
}
/*
[System.Serializable]
public class OwnedPokemon
{
    public string NickName;
    public BaseFighter pokemon;
    public int level;
    public List<PokemonMoves> moves = new List<PokemonMoves>();
}*/