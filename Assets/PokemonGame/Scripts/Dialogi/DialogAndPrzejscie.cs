using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DialogAndPrzejscie : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    private Dialog DMan;
    public bool dialogAktywacja;
    public string CoPowiedziec;
    public string LevelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        DMan = FindObjectOfType<Dialog>();

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
        {
            DMan.ShowBox(CoPowiedziec);
            DMan.dialogAktywacja = true;
            dialogAktywacja = true;
        }
        if (dialogAktywacja && (Input.GetKeyUp(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)))
        {
            dBox.SetActive(false);
            dialogAktywacja = false;
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
