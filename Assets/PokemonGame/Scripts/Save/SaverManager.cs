using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaverManager : MonoBehaviour
{
    private PokemonGameManager gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
    }

    public void LoadMydata()
    {

    }
}
