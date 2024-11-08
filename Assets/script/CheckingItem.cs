using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingItem : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ToCheck;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {
        }
    }
    private void DebugAMountOfItem(Item item)
    {
        UIManager.MyInstance.CheckAmountOfItem(item);
    }
    
}
