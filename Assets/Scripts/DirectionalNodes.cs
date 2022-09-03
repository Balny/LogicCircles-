using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNodes : MonoBehaviour
{
    public Sprite def;
    public Sprite left;
    public Sprite right;
    public string current;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = def;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchSprite();
    }

    void SwitchSprite()
    {
        //Debug.Log("Works");

        if (current == "left")
        {
            sr.sprite = left;
            //Debug.Log("left");
        }
        else if (current == "right")
        {
            sr.sprite = right;
            //Debug.Log("right");
        }
        else
        {
            sr.sprite = def;
            //Debug.Log("default");
        }
    }
}
