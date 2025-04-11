using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using VRTK.Controllables.PhysicsBased;
using VRTK;
using VRTK.Controllables.ArtificialBased;
using VRTK.Controllables;

public class deskLampSwitch : MonoBehaviour
{
    public Light lampLight;
    public bool lampLightOn = true;

    public VRTK_BaseControllable pusher;
    

    private void Start()
    {
        lampLight.enabled = lampLightOn;
        pusher.MaxLimitReached += checkIfPressed;
    }

    private void Update()
    {

    }

    void checkIfPressed(object sender, ControllableEventArgs e)
    {
        lampLightOn = !lampLightOn;
        lampLightController(!lampLightOn);

    }

    void lampLightController(bool state)
    {
        lampLight.enabled = state;
    }
}
