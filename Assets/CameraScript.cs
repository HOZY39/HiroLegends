using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;
    public float PosX;
    public float PosY;
    public bool FreezeX = false;
    public bool FreezeY = false;
    // Start is called before the first frame update
    void Update()
    {
        if (FreezeX)
        {
            gameObject.transform.position = new Vector3(PosX, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (FreezeY)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, PosY, gameObject.transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BorderX")
        {
            PosX = gameObject.transform.position.x;

        }

        if (collision.tag == "BorderY")
        {
            PosY = gameObject.transform.position.y;
        }
    }
    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "BorderX")
        {
            gameObject.transform.position = new Vector3(PosX, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (collision.tag == "BorderY")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, PosY, gameObject.transform.position.z);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "BorderX")
        {
            FreezeX = false;
            gameObject.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -200f);
        }

        if (collision.tag == "BorderY")
        {
        }
    } 
    */
}
