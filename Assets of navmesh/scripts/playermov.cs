using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playermov : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent ag;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                //move our agent
                ag.SetDestination(hit.point);
            }
        }
        
    }
}
