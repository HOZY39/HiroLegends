using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablicaZInfo : MonoBehaviour
{
    public GameObject Ja;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            Ja.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            Ja.SetActive(false);
        }
    }
}
