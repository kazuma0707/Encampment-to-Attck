using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AitemInstiate : MonoBehaviour {

    public GameObject Wall;
     void Start()
    {

    }
    
    // Update is called once per frame
    void Update () {
        //Input.GetKeyDown(KeyCode.Space)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Wall, new Vector3(transform.position.x, transform.position.y, transform.position.z + 5), new Quaternion(0,0,0,0));
        }
    }
}
