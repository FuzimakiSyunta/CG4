using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posision = Vector3.zero;
        Instantiate(block,posision,Quaternion.identity);
        for(int x=0;x<40;x++)
        {
            posision.x = x;
            Instantiate(block, posision, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
