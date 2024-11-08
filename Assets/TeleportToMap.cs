using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToMap : MonoBehaviour
{
    public float X;
    public float Y;
    private ButtonHeld ButtonE;
    private CameraScript CameraPlayer;
    public bool R;
    public bool L;
    void Start()
    {
        ButtonE = GameObject.FindGameObjectWithTag("ButtonE").GetComponent<ButtonHeld>();
        CameraPlayer = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (R)
            {
                collision.transform.position = new Vector3(X, Y, collision.transform.position.z);
            }
            if (L)
            {
                collision.transform.position = new Vector3(X, Y, collision.transform.position.z);
            }
        }
    }
}
