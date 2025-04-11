using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class clockCheck : MonoBehaviour
{
    public TextMeshPro hourText;
    public TextMeshPro minuteText;

    public GameObject hour, minute;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hourText.text = "Hours: " + hour.transform.localEulerAngles.y;
        minuteText.text = "Minutes: " + minute.transform.localEulerAngles.y;
    }
}
