using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using VRTK;

public class pointerRaycast : MonoBehaviour
{

    public GameObject raycastOrigin;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 raycastFwd = raycastOrigin.transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(raycastOrigin.transform.position, raycastFwd * 3f, Color.green);

        if (Physics.Raycast(raycastOrigin.transform.position, raycastOrigin.transform.forward, out hit, 50f))
        {
            if (hit.collider.CompareTag("vrtkCanvas"))
            {
                //Debug.Log("Object hit: " + hit.collider.name);
                Debug.Log("vrtk canvas!");
                
                
                
            }
                
            
        }
        
    }
}
