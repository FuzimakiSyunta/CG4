using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    private float movespeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = rb.velocity;
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v.x = movespeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            v.x = -movespeed;
        }
        else
        {
            v.x = 0f;
        }


        rb.velocity = v;
    }
}
