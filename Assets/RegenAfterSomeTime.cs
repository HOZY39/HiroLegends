using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenAfterSomeTime : MonoBehaviour
{
    public GameObject Object;
    public void Regen(int sec)
    {
        StartCoroutine(RegenAfter(sec));
    }
    IEnumerator RegenAfter(int secs)
    {
        yield return new WaitForSeconds(secs);
        Object.SetActive(true);
    }
}
