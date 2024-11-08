using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DogChange", menuName = "Items/DogChange", order = 1)]
public class DogItem : Item, IUseable
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
        CatMove.Myinstance.BabyChange();
    }
}
