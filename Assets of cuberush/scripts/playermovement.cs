using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fwdforce = 2000f;
    public float sideforce = 500f;
 

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fwdforce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sideforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
        
        
    }
} 
