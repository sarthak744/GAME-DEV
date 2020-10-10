using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movt;
    
    
     void OnCollisionEnter(Collision collisoninfo )
    {
        if(collisoninfo.collider.tag == "obstacle")
        {
            movt.enabled = false;
            FindObjectOfType<gamemanager>().endgame();

        }
    }
}
