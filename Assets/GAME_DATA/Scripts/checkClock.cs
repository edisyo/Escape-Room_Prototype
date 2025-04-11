using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class checkClock : MonoBehaviour
{

    public GameObject hourTick;
    public GameObject minuteTick;
    public VRTK_InteractableObject drawer;
    public float correctHour;
    public float correctMinute;
    public float plusMinusCorrect;

    private bool correctTimeSet;

    // Start is called before the first frame update
    void Start()
    {
        correctTimeSet = false;
        drawer.isGrabbable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!correctTimeSet) correctTimeSet = checkForCorrectTime();

    }

    bool checkForCorrectTime()
    {
        float minHour = correctHour - plusMinusCorrect;
        float maxHour = correctHour + plusMinusCorrect;

        float minMinute = correctMinute - plusMinusCorrect;
        float maxMinute = correctMinute + plusMinusCorrect;

        if ((hourTick.transform.localEulerAngles.y < maxHour && hourTick.transform.localEulerAngles.y > minHour) && (minuteTick.transform.localEulerAngles.y < maxMinute && minuteTick.transform.localEulerAngles.y > minMinute))
        {
            print("CORRECT");
            FindObjectOfType<audioManager>().Play("unlockDrawer");
            drawer.isGrabbable = true;
            return true;
        }
        else
        {
            return false;
        }
    } 
}
