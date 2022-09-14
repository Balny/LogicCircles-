using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        DirectionalNodes dn = other.GetComponent<DirectionalNodes>();
        Debug.Log(dn.current);
        float rot = 0;
        Vector3 dir = Vector3.zero;
        if (dn.current == "right")
        {
            dir = Vector3.back;
            rot = 90;
        }
        else if (dn.current == "left")
        {
            dir = Vector3.forward;
            rot = 90;
        }
        transform.Rotate(dir * rot); //back rotates right and foward rotates left

    }
}
