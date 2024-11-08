using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string LevelToLoad;
    public string PLayerName;
    public int FirstPartner;
    public TMP_Text Name;
    public TMP_Text Name2;
    public TMP_Text Partner;
    public GameObject Config;
    public GameObject SetName;
    public GameObject SetPartner;

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
    public void Play()
    {
        Config.SetActive(true);
    }
    public void ConfirmName()
    {
        NameAndPartner.Name = Name.text;
        Name2.text = Name.text;
    }
    public void ConfirmPartner(int i)
    {
        NameAndPartner.PartnerID = i;
        if(i == 1)
        {
            Partner.text = "Sharbee";
        }
        else if (i == 3)
        {
            Partner.text = "Skullder";
        }
        else
        {
            Partner.text = "Bantit";
        }
    }
    public void Play2()
    {
        Debug.Log(NameAndPartner.PartnerID);
        SceneManager.LoadScene(LevelToLoad);
    }

}
