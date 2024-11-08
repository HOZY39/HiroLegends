using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    [SerializeField]
    private Sprite icon;

    public Sprite MyIcon
    {
        get
        {
            return icon;
        }
    }

    [SerializeField]
    private int stackSize;

    public int MyStackSize
    {
        get
        {
            return stackSize;
        }
    }

    public int myamount;

    public int MyAmount
    {
        get
        {
            return myamount;
        }
        set
        {
            myamount = value;
        }
    }

    private SlotScript slot;

    public SlotScript MySlot
    {
        get
        {
            return slot;
        }
        set
        {
            slot = value;
        }
    }

    public void Remove()
    {
        if (MySlot != null)
        {
            MySlot.RemoveItem(this);
        }
    }
}
