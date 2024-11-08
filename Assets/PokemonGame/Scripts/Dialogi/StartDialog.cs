using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialog : MonoBehaviour
{
    public int IleRazyUzywaszNicku;
    public string CoPowiedziec;
    private Dialog DMan;
    private bool Showbox;
    private PokemonGameManager gm;
    public List<string> CoMowic = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        DMan = FindObjectOfType<Dialog>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PokemonGameManager>();
        if (CoMowic.Count == 2)
        {
            CoPowiedziec = CoMowic[0] + NameAndPartner.Name + CoMowic[1];
        }else if (CoMowic.Count == 1)
        {
            CoPowiedziec = CoMowic[0];
        }
            DMan.ShowBox(CoPowiedziec);
            DMan.dialogAktywacja = true;

    }
}
