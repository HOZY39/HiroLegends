using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAllTrigger : MonoBehaviour
{

    public GameObject HealAll;
    private GameObject SpaceForPotion;
    private MyPokemon MP;
    // Start is called before the first frame update
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            MP.SpaceForMyFirstPokemon.HP = MP.SpaceForMyFirstPokemon.maxHP;
            MP.SpaceForMySecondPokemon.HP = MP.SpaceForMySecondPokemon.maxHP;
            MP.SpaceForMyThirdPokemon.HP = MP.SpaceForMyThirdPokemon.maxHP;
            MP.SpaceForMyFourthPokemon.HP = MP.SpaceForMyFourthPokemon.maxHP;
            MP.SpaceForMyFifthPokemon.HP = MP.SpaceForMyFifthPokemon.maxHP;
            MP.SpaceForMySixthPokemon.HP = MP.SpaceForMySixthPokemon.maxHP;
            MP.SpaceForMyFirstPokemon.HpLossInt = 0;
            MP.SpaceForMySecondPokemon.HpLossInt = 0;
            MP.SpaceForMyThirdPokemon.HpLossInt = 0;
            MP.SpaceForMyFourthPokemon.HpLossInt = 0;
            MP.SpaceForMyFifthPokemon.HpLossInt = 0;
            MP.SpaceForMySixthPokemon.HpLossInt = 0;
        }
    }
}
