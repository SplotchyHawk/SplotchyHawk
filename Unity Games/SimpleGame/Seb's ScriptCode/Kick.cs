using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 20f;
   
    void Start()
    {
        //Increase speed of blocks as time goes on
        force += Time.timeSinceLevelLoad;
    }

    
    void FixedUpdate()
    {

        rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "Backboard")
        {
            Destroy(gameObject);
        }

    }
}
