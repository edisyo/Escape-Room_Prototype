using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rendererDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    

    // Update is called once per frame
    void Update()
    {

        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            list.Add(transform.GetChild(i).gameObject);
        }

        foreach (var child in list)
        {
            
            MeshRenderer mesh = child.GetComponent<MeshRenderer>();
            if (mesh != null) mesh.enabled = false;

        }
    }
}
