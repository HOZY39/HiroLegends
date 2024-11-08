using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokePlMove : MonoBehaviour
{
    public float movementSpeed;
    private SpriteRenderer myspriterenderer;
    private Animator anim;


    public bool MozeChodzic = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MozeChodzic)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                if (Input.GetAxisRaw("Horizontal") > 0.5f)
                {
                    myspriterenderer.flipX = true;
                }

                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0f, 0f));
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime, 0f));
            }
        }

        anim.SetFloat("X", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Y", Input.GetAxisRaw("Vertical"));
    }
}
