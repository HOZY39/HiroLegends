using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Bag", menuName ="Items/Bag", order = 1)]
public class Bag : Item, IUseable
{

    private int slots;

    [SerializeField]
    private GameObject bagPrefab;

    public BagScript MyBagScript { get; set;  }

    public int Slots
    {
        get
        {
            return slots;
        }
    }

    public Sprite MyIcon => throw new System.NotImplementedException();

    public void Initalize(int slots)
    {
        this.slots = slots;
    }

    public void Use()
    {

        if (InventoryScript.Myinstance.CanAddBag)
        {

            Remove();
            MyBagScript = Instantiate(bagPrefab, InventoryScript.Myinstance.transform).GetComponent<BagScript>();
            MyBagScript.Addslots(slots);

            InventoryScript.Myinstance.AddBag(this);

        }

    }
}
