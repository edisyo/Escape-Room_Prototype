using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger : MonoBehaviour
{
    public Animator anim;
    public Light RoomLight;
    // Start is called before the first frame update
    void Start()
    {
        RoomLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "key")
        {
            anim.SetTrigger("openDoors");
            RoomLight.gameObject.SetActive(true);
        }
    }
}
