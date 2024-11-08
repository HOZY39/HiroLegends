using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;

    private CanvasGroup canvasGroup;

    private List<SlotScript> slots = new List<SlotScript>();

    public List<SlotScript> MySlots
    {
        get
        {
            return slots;
        }
    }

    public void Addslots(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            SlotScript slot = Instantiate(slotPrefab, transform).GetComponent<SlotScript>();
            MySlots.Add(slot);
        }
    }


    public bool AddItem(Item item)
    {
        foreach(SlotScript slot in MySlots)
        {
            if (slot.IsEmpty)
            {
                slot.AddItem(item);

                return true;
            }
        }
        return false;
    }

    public void Awake()
    { 
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = canvasGroup.alpha > 0 ? 0 : 1;
    }

    public void OpenClose()
    {
        canvasGroup.alpha = canvasGroup.alpha > 0 ? 0 : 1;

        canvasGroup.blocksRaycasts = canvasGroup.blocksRaycasts == true ? false : true;
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Bag != null)
            {
                OpenClose();
            }
        }
    }*/
}
