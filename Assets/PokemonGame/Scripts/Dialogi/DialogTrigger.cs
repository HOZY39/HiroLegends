using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public string CoPowiedziec;
    private Dialog DMan;
    private bool Showbox;
    private PokemonGameManager gm;
    public List<string> CoMowicRozbite = new List<string>();
    private ButtonHeld ButtonE;
    // Start is called before the first frame update
    void Start()
    {
        DMan = FindObjectOfType<Dialog>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        ButtonE = GameObject.FindGameObjectWithTag("ButtonE").GetComponent<ButtonHeld>();
    }


    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            if (CoMowic.Count == 2)
            {
                CoPowiedziec = CoMowic[0] + gm.MyNick + CoMowic[1];
            }
            DMan.ShowBox(CoPowiedziec);
            DMan.dialogAktywacja = true;
        }
    }*/
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.E) || ButtonE.buttonPressed))
        {
            if (CoMowicRozbite.Count > 0)
            {
                StartCoroutine("DialogRozbity", true);
            }
            else
            {
                DMan.ShowBox(CoPowiedziec);
            }
        }
    }
    
    IEnumerator DialogRozbity(bool wait)
    {
        for (int i = 0; i <= CoMowicRozbite.Count; i++)
        {
            if (i == 0)
            {
                CoPowiedziec = CoMowicRozbite[i];
                DMan.RShowBox(CoPowiedziec);
                wait = false;
                print(i);
            }
            while (wait)
            {
                if ((Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) & i != CoMowicRozbite.Count)
                {
                    CoPowiedziec = CoMowicRozbite[i];
                    DMan.RShowBox(CoPowiedziec);
                    wait = false;
                }
                if (i == CoMowicRozbite.Count & (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
                {
                    print("koniec");
                    print(i);
                    print(CoMowicRozbite.Count);
                    DMan.HideBox();
                    wait = false;
                }
                yield return null;
            }
            wait = true;
        }
    }
    IEnumerator Skip(bool wait)
    {
        while (wait)
        {
            if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                DMan.dBox.SetActive(false);
                DMan.dialogAktywacja = false;
                wait = false;
            }
            yield return null;
        }
    }
}
