using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAllPokemon : MonoBehaviour
{

    private MyPokemon MP;
    private BattleManager BM;
    // Start is called before the first frame update
    void Start()
    {

        MP = GameObject.FindGameObjectWithTag("MyPokemon").GetComponent<MyPokemon>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
    }
    public void HealAll()
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
