using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatMove : MonoBehaviour
{
    public float movementSpeed;
    private Animator anim;

    public bool MozeChodzic = false;
    private SpriteRenderer mySpriteRenderer;

    public RuntimeAnimatorController anim1;
    public RuntimeAnimatorController anim2;
    public RuntimeAnimatorController anim3;
    public ButtonHeld Up;
    public ButtonHeld Down;
    public ButtonHeld Right;
    public ButtonHeld Left;
    public GameObject Camera;
    public CameraScript CameraS;

    private static CatMove instance;

    public static CatMove Myinstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CatMove>();
            }
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        BabyChange();
    }

    // Update is called once per frame
    void Update()
    {
        if (MozeChodzic)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0f, 0f));
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime, 0f));
            }
            anim.SetFloat("X", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("Y", Input.GetAxisRaw("Vertical"));
            /*
            if (Up.buttonPressed)
            {
                transform.Translate(new Vector3(0f, 1f * movementSpeed * Time.deltaTime, 0f));
                anim.SetFloat("Y", 1f);
            }
            if (Down.buttonPressed)
            {
                transform.Translate(new Vector3(0f, -1f * movementSpeed * Time.deltaTime, 0f));
                anim.SetFloat("Y", -1f);
            }
            if (Right.buttonPressed)
            {
                transform.Translate(new Vector3(1 * movementSpeed * Time.deltaTime, 0f, 0f));
                anim.SetFloat("X", 1f);
            }
            if (Left.buttonPressed)
            {
                transform.Translate(new Vector3(-1 * movementSpeed * Time.deltaTime, 0f, 0f));
                anim.SetFloat("X", -1f);
            }
            if (!Left.buttonPressed  && !Right.buttonPressed)
            {
                anim.SetFloat("X", 0f);
            }
            if (!Up.buttonPressed && !Down.buttonPressed)
            {
                anim.SetFloat("Y", 0f);
            }
            */
        }

    }

    public void PokeChange()
    {
        if (anim != null && anim.isActiveAndEnabled && anim.runtimeAnimatorController != null)
        {
            this.GetComponent<Animator>().runtimeAnimatorController = anim2 as RuntimeAnimatorController;
        }
    }
    public void BabyChange()
    {
        if (anim != null && anim.isActiveAndEnabled && anim.runtimeAnimatorController != null)
        {
            this.GetComponent<Animator>().runtimeAnimatorController = anim1 as RuntimeAnimatorController;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "tree")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, collision.transform.position.z + 1f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "tree")
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 50f);
        }
        if (collision.tag == "BorderX")
        {
            CameraS.FreezeX = false;
            Camera.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Camera.transform.position.z);
        }
        if (collision.tag == "BorderY")
        {
            CameraS.FreezeY = false;
            Camera.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Camera.transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BorderX")
        {
            CameraS.PosX = Camera.transform.position.x;
            CameraS.FreezeX = true;
        }
        if (collision.tag == "BorderY")
        {
            CameraS.PosY = Camera.transform.position.y;
            CameraS.FreezeY = true;
        }
    }
}
