using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    private Animator anim;
    public bool Left;
    public bool Right;
    public bool Up;
    public bool Down;
    public int movement;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Left == true)
        {
            anim.SetFloat("X", -0.6f);
            transform.Translate(new Vector3(-0.5f * movement * Time.deltaTime, 0f, 0f));
        }
        else if (Right == true)
        {
            anim.SetFloat("X", 0.6f);
            transform.Translate(new Vector3(0.5f * movement * Time.deltaTime, 0f, 0f));
        }
        else
        {
            anim.SetFloat("X", 0f);
        }


        if (Up == true)
        {
            anim.SetFloat("Y", 0.6f);
            transform.Translate(new Vector3(0f, 0.5f * movement * Time.deltaTime, 0f));
        }
        else if (Down == true)
        {
            anim.SetFloat("Y", -0.6f);
            transform.Translate(new Vector3(0f, -0.5f * movement * Time.deltaTime, 0f));
        }
        else
        {
            anim.SetFloat("Y", 0f);
        }
    }
}
