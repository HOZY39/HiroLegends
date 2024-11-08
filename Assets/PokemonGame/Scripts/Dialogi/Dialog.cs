using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogAktywacja;
    private bool abcd;
    // Start is called before the first frame update
    void Start()
    {

    }
    /*
    void SkipDialog()
    {
        if (dialogAktywacja && Input.GetKeyUp(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogAktywacja = false;
            abcd = true;
        }
        if (abcd && Input.GetKeyDown(KeyCode.Space))
        {
            dBox.SetActive(false);
            dialogAktywacja = false;
            abcd = false;
        }
    }*/
    public void ShowBox(string CoPowiedziec)
    {
        dialogAktywacja = true;
        dBox.SetActive(true);
        dText.text = CoPowiedziec;
        StartCoroutine("Skip", true);
    }
    public void AfterBattleShowBox(string CoPowiedziec)
    {
        dialogAktywacja = true;
        dBox.SetActive(true);
        dText.text = CoPowiedziec;
        StartCoroutine("AfterBattleSkip", true);
    }
    public void RShowBox(string CoPowiedziec)
    {
        dialogAktywacja = true;
        dBox.SetActive(true);
        dText.text = CoPowiedziec;
    }
    public void HideBox()
    {
        dialogAktywacja = false;
        dBox.SetActive(false);
    }
    IEnumerator Skip(bool wait)
    {
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                dBox.SetActive(false);
                dialogAktywacja = false;
                wait = false;
            }
            yield return null;
        }
    }
    IEnumerator AfterBattleSkip(bool wait)
    {
        bool skip = false;
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                print("skipPart1");
                skip = true;
                wait = false;
            }
            yield return null;
        }
        wait = true;
        while (wait)
        {
            if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) & skip)
            {
                print("skipPart2");
                dBox.SetActive(false);
                dialogAktywacja = false;
                wait = false;
            }
            yield return null;
        }
    }
}
