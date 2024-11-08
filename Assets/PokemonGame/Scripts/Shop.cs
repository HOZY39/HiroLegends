using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopMenu;
    private PokemonGameManager gm;
    private InventoryScript IS;
    private BattleManager BM;
    private bool CanShop = true;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        IS = GameObject.FindGameObjectWithTag("InventoryScript").GetComponent<InventoryScript>();
        BM = GameObject.FindGameObjectWithTag("BattleMNG").GetComponent<BattleManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E) && CanShop==true)
            {
                ShopMenu.SetActive(true);
                CanShop = false;
            }
        }
    }
    
    public void BuyHpPotion()
    {
        if (BM.AmountOfMoney >= 20)
        {
            PotionItem HpPotion = (PotionItem)Instantiate(IS.items[4]);
            IS.AddItem(HpPotion);
            CanShop = true;
            BM.AmountOfMoney -= 20;
            BM.MoneyText.text = BM.AmountOfMoney.ToString();

        }
    }
    public void Exit()
    {
        ShopMenu.SetActive(false);
    }
}
