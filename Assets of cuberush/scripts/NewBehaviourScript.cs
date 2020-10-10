using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        score.text = ((player.position.z)+30.3).ToString("0");
    }
    
    
}
