using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoxusMoves : MonoBehaviour
{

    public PokemonScript Pokemon1;
    public PokemonScript Pokemon2;
    public PokemonScript Pokemon3;
    public PokemonScript Pokemon4;
    public PokemonScript Pokemon5;
    public PokemonScript Pokemon6;

    public int ForKalistaE = 0;

    public float damage;
    public float MagicDamage;
    public float DMG;

    public bool MyParanoia = false;
    public bool EnemyParanoia = false;

    public PokemonScript EnemyPokemon;

    public PokemonScript MyPokemon;

    private PokemonGameManager gm;
    private BattleManager BM;

    public int quantity;



    public delegate void AllNoxusMoves();
    public List<AllNoxusMoves> NoxusMovess = new List<AllNoxusMoves>();
    public void CreateListDraven()
    {
        NoxusMovess.Add(EMPTY_MOVE);
        NoxusMovess.Add(StingerShot);
        NoxusMovess.Add(PoisonSting);
        NoxusMovess.Add(HealingHoney);
        NoxusMovess.Add(FastWings);
        NoxusMovess.Add(Bite);
        NoxusMovess.Add(Growl);
        NoxusMovess.Add(DetectEnemy);
        NoxusMovess.Add(Larvas);
        NoxusMovess.Add(Web);
        //10
        NoxusMovess.Add(Venom);
        NoxusMovess.Add(Jump);
        NoxusMovess.Add(RedEyes);
        NoxusMovess.Add(Suction);
        NoxusMovess.Add(Scream);
        NoxusMovess.Add(SmellEnemy);
        NoxusMovess.Add(Recovery);
        NoxusMovess.Add(KnifeThrow);
        NoxusMovess.Add(DoubleTheKnife);
        NoxusMovess.Add(ChitinArmor);
        //20
        NoxusMovess.Add(CallHomies);
        NoxusMovess.Add(Suffocation);
        NoxusMovess.Add(SkinShed);
        NoxusMovess.Add(Hardness);
        NoxusMovess.Add(SpittingVenom);
    }
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
        CreateListDraven();
        NoxusMovess[0]();
    }

    
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            NoxusMovess[0]();
        }
    }

    public void Damage(float power)
    {
        DMG = ((((((2 * MyPokemon.level) / 5)+2) * power * ((float)MyPokemon.AttackStat / (float)EnemyPokemon.DefenceStat) ) / 50) + 2);
    }
    public void EMPTY_MOVE()
    {
    }
    //Sharbee
    public void StingerShot()
    {
        Damage(gm.AllMoves[1].power);
        EnemyPokemon.HP -= (int)DMG;
    }
    public void PoisonSting()
    {
        Damage(gm.AllMoves[2].power);
        EnemyPokemon.HP -= (int)DMG;
        EnemyPokemon.status = Status.Poisoned;
    }
    public void HealingHoney()
    {
        MyPokemon.HP += (int)(MyPokemon.maxHP/2);
    }
    public void FastWings()
    {
        MyPokemon.SpeedStat += (int)(MyPokemon.SpeedStat / 5);
        MyPokemon.AttackStat += (int)(MyPokemon.AttackStat / 5);
        MyPokemon.DefenceStat += (int)(MyPokemon.DefenceStat / 5);
    }



    //Larjaw
    public void Bite()
    {
        Damage(gm.AllMoves[5].power);
        EnemyPokemon.HP -= (int)DMG;
        int random = Random.Range(1, 10);
        if (random <= 4)
        {
            EnemyPokemon.status = Status.Bleeding;
        }
    }
    public void Growl()
    {
        EnemyPokemon.SpeedStat -= (int)(EnemyPokemon.SpeedStat / 5);
        EnemyPokemon.AttackStat -= (int)(EnemyPokemon.AttackStat / 5);
        EnemyPokemon.DefenceStat -= (int)(EnemyPokemon.DefenceStat / 5);
    }
    public void DetectEnemy()
    {
        MyPokemon.AttackStat += (int)(MyPokemon.AttackStat / 2.5);
    }
    public void Larvas()
    {
        Damage(gm.AllMoves[8].power);
        quantity = 0;
        for (int i = 0; i < 4; i++)
        {
            int random = Random.Range(1, 10);
            if (random <= 4)
            {
                quantity++;
            }
        }
        for (int i = 0; i <= quantity; i++)
        {
            EnemyPokemon.HP -= (int)DMG;
        }
    }
    //Skullder

    public void Web()
    {
        EnemyPokemon.SpeedStat -= (int)(EnemyPokemon.SpeedStat / 5);
        EnemyPokemon.AttackStat -= (int)(EnemyPokemon.AttackStat / 5);
        EnemyPokemon.DefenceStat -= (int)(EnemyPokemon.DefenceStat / 5);
    }
    public void Venom()
    {
        EnemyPokemon.status = Status.Poisoned;
    }
    public void Jump()
    {
        Damage(gm.AllMoves[11].power);
        EnemyPokemon.HP -= (int)DMG;
    }
    public void RedEyes()
    {
        EnemyPokemon.AttackStat -= (int)(EnemyPokemon.AttackStat / 3);
    }
    // Worjaw
    public void Suction()
    {
        Damage(gm.AllMoves[13].power);
        EnemyPokemon.HP -= (int)DMG;
        int random = Random.Range(1, 10);
        if (random <= 2)
        {
            EnemyPokemon.status = Status.Bleeding;
        }
        MyPokemon.HP += (int)(DMG/2);
    }
    public void Scream()
    {
        EnemyPokemon.SpeedStat -= (int)(EnemyPokemon.SpeedStat / 5);
        EnemyPokemon.AttackStat -= (int)(EnemyPokemon.AttackStat / 5);
        EnemyPokemon.DefenceStat -= (int)(EnemyPokemon.DefenceStat / 5);
    }
    public void SmellEnemy()
    {
        MyPokemon.AttackStat += (int)(MyPokemon.AttackStat / 2.5);
    }
    public void Recovery()
    {
        MyPokemon.HP += (int)(MyPokemon.maxHP / 2);
    }
    // Bantit

    public void KnifeThrow()
    {
        Damage(gm.AllMoves[17].power);
        EnemyPokemon.HP -= (int)DMG;
    }
    public void DoubleTheKnife()
    {
        MyPokemon.AttackStat += (int)(MyPokemon.AttackStat / 4);
    }
    public void ChitinArmor()
    {
        MyPokemon.DefenceStat += (int)(MyPokemon.DefenceStat / 4);
        MyPokemon.SpeedStat -= (int)(MyPokemon.SpeedStat / 4);
    }
    public void CallHomies()
    {
        Damage(gm.AllMoves[20].power);
        quantity = 0;
        for (int i = 0; i < 4; i++)
        {
            int random = Random.Range(1, 10);
            if (random <= 4)
            {
                quantity++;
            }
        }
        for (int i = 0; i <= quantity; i++)
        {
            EnemyPokemon.HP -= (int)DMG;
        }
    }
    // Snablin
    public void Suffocation()
    {
        int random = Random.Range(1, 5);
        Damage((gm.AllMoves[21].power)*random);
        EnemyPokemon.HP -= (int)DMG;
    }
    public void SkinShed()
    {
        MyPokemon.HP += (int)(MyPokemon.maxHP / 1.5);
    }
    public void Hardness()
    {
        MyPokemon.DefenceStat += (int)(MyPokemon.DefenceStat / 4);
    }
    public void SpittingVenom()
    {
        EnemyPokemon.status = Status.Poisoned;
    }
}
