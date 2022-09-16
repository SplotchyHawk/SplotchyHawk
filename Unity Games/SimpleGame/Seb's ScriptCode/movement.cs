using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb;
    public float lateralForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(0,0, -100 * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(0,0, 100 * Time.deltaTime, ForceMode.VelocityChange);
        }
       
    }
}
