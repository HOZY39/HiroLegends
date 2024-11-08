using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestItem", menuName = "Items/cos", order = 1)]
public class TestItem : Item, IUseable
{

    public void Use()
    {
        Remove();

        Debug.Log("itemek");
    }
}
