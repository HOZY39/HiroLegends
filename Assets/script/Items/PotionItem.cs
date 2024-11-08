using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HpPotion", menuName = "Items/HpPotion", order = 1)]
public class PotionItem : Item, IUseable
{
    [SerializeField]
    private int cos;

    [SerializeField]
    private int AmountOfHpHealed;

    [SerializeField]
    public GameObject ChoosePokemonToHeal;

    [SerializeField]
    public GameObject ItemInfo;
    private GameObject SpaceForPotion;
    public void Use()
    {
        Remove();
        SpaceForPotion = GameObject.FindGameObjectWithTag("Canvas");
        GameObject UsePotion = Instantiate(ChoosePokemonToHeal, SpaceForPotion.transform.position, Quaternion.identity) as GameObject;
        UsePotion.transform.parent = SpaceForPotion.transform;
    }
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }
}
