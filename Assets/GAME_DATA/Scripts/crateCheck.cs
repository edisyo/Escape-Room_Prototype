using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

public class crateCheck : MonoBehaviour
{
    public int snaps;
    private bool hasOpened = false;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        snaps = 0;
        hasOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(snaps == 4)
        {
            //play anim
            if(anim != null && !hasOpened)
            {
                hasOpened = true;
                Debug.Log("Playing animation...");
                FindObjectOfType<audioManager>().Play("unlockChest");
                anim.SetTrigger("openCrate");
            }
            
        }
    }

    public void onSnap()
    {
        snaps += 1;
    }

    public void onDesnap()
    {
        snaps -= 1;
    }
}
