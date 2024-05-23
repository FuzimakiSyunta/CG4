using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    private float movespeed = 5.0f;
    private float jumpspeed = 5.0f;
    private bool isBlock = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = rb.velocity;
        if (GoalScript.isGameClear == false)
        {
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
    void Update()
    {
        Vector3 v = rb.velocity;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            v.y = jumpspeed;
        }
        rb.velocity = v;
        //
        Vector3 rayPosition = transform.position;
        Ray ray = new Ray(rayPosition,Vector3.down);

        float distance = 0.6f;
        Debug.DrawRay(rayPosition,Vector3.down*distance,Color.red);

        isBlock = Physics.Raycast(ray,distance);

        if (isBlock == true)
        {
            Debug.DrawRay(rayPosition,Vector3.down*distance);
        }else
        {
            Debug.DrawRay(rayPosition,Vector3.down*distance,Color.yellow);
        }
    }

}
