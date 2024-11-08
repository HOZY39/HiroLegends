using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegetables : MonoBehaviour
{
    public GameObject HealAll;
    private MyPokemon MP;
    public int Heal;
    private ButtonHeld ButtonE;
    public RegenAfterSomeTime Daddy;
    public int CD;
    // Start is called before the first frame update
    void Start()
    {
        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
        ButtonE = GameObject.FindGameObjectWithTag("ButtonE").GetComponent<ButtonHeld>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && (Input.GetKeyDown(KeyCode.E) || ButtonE.buttonPressed))
        {
            MP.SpaceForMyFirstPokemon.HP += Heal;
            MP.SpaceForMySecondPokemon.HP += Heal;
            MP.SpaceForMyThirdPokemon.HP += Heal;
            MP.SpaceForMyFourthPokemon.HP += Heal;
            MP.SpaceForMyFifthPokemon.HP += Heal;
            MP.SpaceForMySixthPokemon.HP += Heal;
            MP.SpaceForMyFirstPokemon.HpLossInt += Heal;
            MP.SpaceForMySecondPokemon.HpLossInt += Heal;
            MP.SpaceForMyThirdPokemon.HpLossInt += Heal;
            MP.SpaceForMyFourthPokemon.HpLossInt += Heal;
            MP.SpaceForMyFifthPokemon.HpLossInt += Heal;
            MP.SpaceForMySixthPokemon.HpLossInt += Heal;
            ///////////////////////////////////////////////////////////////////
            if (MP.SpaceForMyFirstPokemon.HP > MP.SpaceForMyFirstPokemon.maxHP)
            {
                MP.SpaceForMyFirstPokemon.HP = MP.SpaceForMyFirstPokemon.maxHP;
            }
            if (MP.SpaceForMySecondPokemon.HP > MP.SpaceForMySecondPokemon.maxHP)
            {
                MP.SpaceForMySecondPokemon.HP = MP.SpaceForMySecondPokemon.maxHP;
            }
            if (MP.SpaceForMyThirdPokemon.HP > MP.SpaceForMyThirdPokemon.maxHP)
            {
                MP.SpaceForMyThirdPokemon.HP = MP.SpaceForMyThirdPokemon.maxHP;
            }
            if (MP.SpaceForMyFourthPokemon.HP > MP.SpaceForMyFourthPokemon.maxHP)
            {
                MP.SpaceForMyFourthPokemon.HP = MP.SpaceForMyFourthPokemon.maxHP;
            }
            if (MP.SpaceForMyFifthPokemon.HP > MP.SpaceForMyFifthPokemon.maxHP)
            {
                MP.SpaceForMyFifthPokemon.HP = MP.SpaceForMyFifthPokemon.maxHP;
            }
            if (MP.SpaceForMySixthPokemon.HP > MP.SpaceForMySixthPokemon.maxHP)
            {
                MP.SpaceForMySixthPokemon.HP = MP.SpaceForMySixthPokemon.maxHP;
            }
            ///////////////////////////////////////////////////////////////////
            if (MP.SpaceForMyFirstPokemon.HpLossInt > 0)
            {
                MP.SpaceForMyFirstPokemon.HpLossInt = 0;
            }
            if (MP.SpaceForMySecondPokemon.HpLossInt > 0)
            {
                MP.SpaceForMySecondPokemon.HpLossInt = 0;
            }
            if (MP.SpaceForMyThirdPokemon.HpLossInt > 0)
            {
                MP.SpaceForMyThirdPokemon.HpLossInt = 0;
            }
            if (MP.SpaceForMyFourthPokemon.HpLossInt > 0)
            {
                MP.SpaceForMyFourthPokemon.HpLossInt = 0;
            }
            if (MP.SpaceForMyFifthPokemon.HpLossInt > 0)
            {
                MP.SpaceForMyFifthPokemon.HpLossInt = 0;
            }
            if (MP.SpaceForMySixthPokemon.HpLossInt > 0)
            {
                MP.SpaceForMySixthPokemon.HpLossInt = 0;
            }
            Daddy.Regen(CD);
            gameObject.SetActive(false);
        }
    }
}
