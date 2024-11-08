using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

    private static InventoryScript instance;

    public static InventoryScript Myinstance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<InventoryScript>();
            }
            return instance;
        }
    }

    private List<Bag> bags = new List<Bag>();

    [SerializeField]
    private BagButton[] bagButtons;

    public bool CanAddBag
    {
        get { return bags.Count < 5; }
    }



    [SerializeField]    
    public Item[] items;


    private void Awake()
    {
        Bag bag = (Bag)Instantiate(items[0]);
        bag.Initalize(20);
        bag.Use();
    }
    

    public void AddBag(Bag bag)
    {
        foreach (BagButton bagButton in bagButtons)
        {
            if (bagButton.MyBag == null)
            {
                bagButton.MyBag = bag;
                bags.Add(bag);
                break;
            }
        }
    }

    public void AddItem(Item item)
    {
        if (item.MyStackSize > 0)
        {
            if (PlaceInStack(item))
            {
                return;
            }
        }
        PlaceInEmpty(item);
        item.myamount = item.myamount + 1;
    }

    private void PlaceInEmpty(Item item)
    {
        foreach ( Bag bag in bags)
        {
            if (bag.MyBagScript.AddItem(item))
            {
                return;
            }
        }
    }

    private bool PlaceInStack(Item item)
    {
        foreach (Bag bag in bags)
        {
            foreach(SlotScript slots in bag.MyBagScript.MySlots)
            {
                if (slots.StackItem(item))
                {
                    return true;
                }
            }
        }

        return false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Bag bag = (Bag)Instantiate(items[0]);
            bag.Initalize(20);
            AddItem(bag);
        }

        /* 
         */
        if (Input.GetKeyDown(KeyCode.L))
         {
             TestItem cos = (TestItem)Instantiate(items[3]);
             AddItem(cos);
         }
         if (Input.GetKeyDown(KeyCode.J))
         {
             DogItem dog = (DogItem)Instantiate(items[1]);
             AddItem(dog);
         }
        if (Input.GetKeyDown(KeyCode.M))
        {
            CatItem cat = (CatItem)Instantiate(items[2]);
            AddItem(cat);
        } 
        if (Input.GetKeyDown(KeyCode.H))
        {
            PotionItem HpPotion = (PotionItem)Instantiate(items[4]);
            AddItem(HpPotion);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            CheckNumberOfItem();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            CatItem cat = (CatItem)Instantiate(items[2]);

            DebugAMountOfItem(cat);
        }

    }
    void CheckNumberOfItem()
    {
        int n;
        n = 0;
        foreach (Item item in items)
        {
            n++;
        }
        Debug.Log(n);
    }
    private void DebugAMountOfItem(Item item)
    {
        UIManager.MyInstance.CheckAmountOfItem(item);
    }
}

