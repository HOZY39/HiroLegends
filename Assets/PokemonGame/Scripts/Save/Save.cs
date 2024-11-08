using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject player;

    public PokemonScript Pokemon1;
    public PokemonScript Pokemon2;
    public PokemonScript Pokemon3;
    public PokemonScript Pokemon4;
    public PokemonScript Pokemon5;
    public PokemonScript Pokemon6;

    public PokemonMoves asdff;
    public PokemonMoves asda;
    public PokemonMoves asdf;
    public PokemonMoves asd;
    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefs.GetInt("Saved") == 1 && PlayerPrefs.GetInt("TimeToLoad") == 1)
        {
            float pX = player.transform.position.x;
            float pY = player.transform.position.y;
            float pZ = player.transform.position.z;

            pX = PlayerPrefs.GetFloat("p_x");
            pY = PlayerPrefs.GetFloat("p_y");
            pZ = PlayerPrefs.GetFloat("p_z");
            player.transform.position = new Vector3(pX, pY, pZ);
            PlayerPrefs.SetInt("TimeToLoad", 0);
            PlayerPrefs.Save();
        }

    }

    // Update is called once per frame
    public void PlayerPosSave()
    {
        PlayerPrefs.SetFloat("p_x", player.transform.position.x);
        PlayerPrefs.SetFloat("p_y", player.transform.position.y);
        PlayerPrefs.SetFloat("p_z", player.transform.position.z);
        PlayerPrefs.SetInt("Saved", 1);
        PlayerPrefs.Save();
    }
    public void PlayerPosSaveBoss()
    {
        PlayerPrefs.SetFloat("p_x", player.transform.position.x);
        PlayerPrefs.SetFloat("p_y", player.transform.position.y - 2);
        PlayerPrefs.SetFloat("p_z", player.transform.position.z);
        PlayerPrefs.SetInt("Saved", 1);
        PlayerPrefs.Save();
    }
    /*
    public void SaveMyPokemon()
    {
        //HP
        PlayerPrefs.SetInt("Poke1HP", Pokemon1.HP);
        PlayerPrefs.SetInt("Poke2HP", Pokemon2.HP);
        PlayerPrefs.SetInt("Poke3HP", Pokemon3.HP);
        PlayerPrefs.SetInt("Poke4HP", Pokemon4.HP);
        PlayerPrefs.SetInt("Poke5HP", Pokemon5.HP);
        PlayerPrefs.SetInt("Poke6HP", Pokemon6.HP);
        //MaxHP
        PlayerPrefs.SetInt("Poke1MaxHP", Pokemon1.maxHP);
        PlayerPrefs.SetInt("Poke2MaxHP", Pokemon2.maxHP);
        PlayerPrefs.SetInt("Poke3MaxHP", Pokemon3.maxHP);
        PlayerPrefs.SetInt("Poke4MaxHP", Pokemon4.maxHP);
        PlayerPrefs.SetInt("Poke5MaxHP", Pokemon5.maxHP);
        PlayerPrefs.SetInt("Poke6MaxHP", Pokemon6.maxHP);
        //NAME
        PlayerPrefs.SetString("Poke1Name", Pokemon1.Name);
        PlayerPrefs.SetString("Poke2Name", Pokemon2.Name);
        PlayerPrefs.SetString("Poke3Name", Pokemon3.Name);
        PlayerPrefs.SetString("Poke4Name", Pokemon4.Name);
        PlayerPrefs.SetString("Poke5Name", Pokemon5.Name);
        PlayerPrefs.SetString("Poke6Name", Pokemon6.Name);
        //Lvl
        PlayerPrefs.SetInt("Poke1Lvl", Pokemon1.level);
        PlayerPrefs.SetInt("Poke2Lvl", Pokemon2.level);
        PlayerPrefs.SetInt("Poke3Lvl", Pokemon3.level);
        PlayerPrefs.SetInt("Poke4Lvl", Pokemon4.level);
        PlayerPrefs.SetInt("Poke5Lvl", Pokemon5.level);
        PlayerPrefs.SetInt("Poke6Lvl", Pokemon6.level);
        //MoveICanuse

        PlayerPrefs.SetInt("Saved", 1);
    }*/
    public void PlayerPosLoad()
    {
        PlayerPrefs.SetInt("TimeToLoad", 1);
        PlayerPrefs.Save();
    }
    public void OnDestroy()
    {
        PlayerPrefs.SetInt("TimeToLoad", 1);
        PlayerPrefs.Save();
    }
}