using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    
    void OnTriggerEnter()
    {
        FindObjectOfType<gamemanager>().complete();
        
    }
}
