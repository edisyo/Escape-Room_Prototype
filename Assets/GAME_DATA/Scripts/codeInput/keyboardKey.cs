using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;
using VRTK.Controllables.ArtificialBased;

public class keyboardKey : MonoBehaviour
{
    public string keyToInput;
    private VRTK_BaseControllable pusher;
    private inputManager _inputManager;

    // Start is called before the first frame update
    void Start()
    {
        pusher = gameObject.GetComponent<VRTK_ArtificialPusher>();
        pusher.MaxLimitReached += ifPressed;
        _inputManager = FindObjectOfType<inputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ifPressed(object sender, ControllableEventArgs e)
    {
        if(keyToInput != null)
        {
            _inputManager.getKey(keyToInput);
            //print("sent key:" + keyToInput);
            FindObjectOfType<audioManager>().Play("keyboard");
        }
        
    }
}
