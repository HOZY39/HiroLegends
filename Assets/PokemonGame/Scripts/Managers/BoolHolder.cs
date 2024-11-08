using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolHolder : MonoBehaviour
{
    public GameObject Guest1;
    public GameObject Guest2;
    
    public void guest2Active()
    {
        Guest2.SetActive(true);
    }
}
