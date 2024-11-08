using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CatChange", menuName = "Items/CatChange", order = 1)]
public class CatItem : Item, IUseable
{
    [SerializeField]
    private int cos;

    private Animator anim;

    [SerializeField]
    protected GameObject Dog;

    [SerializeField]
    protected GameObject Cat;

    public GameObject Postac;


    private CatMove CatMove;

    public void Use()
    {
        Remove();
        CatMove.Myinstance.PokeChange();
    }
}
