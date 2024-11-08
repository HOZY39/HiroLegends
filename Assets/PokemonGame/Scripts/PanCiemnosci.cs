using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanCiemnosci : MonoBehaviour
{
    public PokemonScript First;
    public PokemonScript Second;
    public PokemonScript Third;
    public PokemonScript Fourth;
    public PokemonScript Fiveth;
    public PokemonScript Sixth;
    public GameObject DialogTak;
    public GameObject DialogNie;
    public GameObject Walka;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (First.MyExp < 1000)
            {
                DialogTak.SetActive(false);
                DialogNie.SetActive(true);
                Walka.SetActive(false);
            }
            if (First.MyExp >= 1000)
            {
                DialogTak.SetActive(true);
                DialogNie.SetActive(false);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Walka.SetActive(true);
                }
            }
        }
    }
}
