using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZPosFix : MonoBehaviour
{
    public GameObject Player;
    public float FixedY;
    public int FixedZUp;
    public int FixedZDown;
    private Vector3 FirstPos;
    private void Start()
    {
        FirstPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Player.transform.position.y>gameObject.transform.position.y+FixedY)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, FixedZUp);
            }
            else
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, FixedZDown);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.transform.position = FirstPos;
        }
    }
}
