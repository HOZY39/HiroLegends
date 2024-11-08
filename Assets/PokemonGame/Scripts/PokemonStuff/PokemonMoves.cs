using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PokemonMoves : MonoBehaviour
{
    public string Name;
    public MoveType category;
    public PokemonType moveType;
    public int PP;
    public int power;
    public int accuracy;
    public int MyIndex;
    public Status StatusIMake;

    public bool RiseATK;
    public bool RiseSpeed;
    public bool RiseDef;

    public bool DecreaseATK;
    public bool DecreaseSpeed;
    public bool DecreaseDeff;

    public bool MeDecreaseATK;
    public bool MeDecreaseSpeed;
    public bool MeDecreaseDeff;

    public string Description;
}

[System.Serializable]
public enum MoveType
{
    Physical,
    Special,
    Status
}
