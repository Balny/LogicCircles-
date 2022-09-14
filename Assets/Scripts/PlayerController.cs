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
        transform.Rotate(Vector3.back * 90); //back rotates right and foward rotates left
        Debug.Log("hit");
    }
}
