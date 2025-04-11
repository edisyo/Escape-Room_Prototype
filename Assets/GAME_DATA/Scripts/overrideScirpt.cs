using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overrideScirpt : MonoBehaviour
{
    private bool hasChecked = false;

    public Rigidbody rb;
    public HingeJoint hinge;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hinge = GetComponent<HingeJoint>();
    }

    private void FixedUpdate()
    {
        check();
    }

    void check()
    {

        if (!hasChecked)
        {
            print("");
            if (rb != null) rb.isKinematic = true;
            if (hinge != null) hinge.useSpring = false;
            hasChecked = true;
        }

    }
}
