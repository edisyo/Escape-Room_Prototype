using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using VRTK.Controllables;

public class inputManager : MonoBehaviour
{

    public TextMeshProUGUI codeField1;
    public TextMeshProUGUI codeField2;
    public TextMeshProUGUI codeField3;
    public TextMeshProUGUI codeField4;

    private string inputCode;


    void Start()
    {
        codeField1.text = "";
        codeField2.text = "";
        codeField3.text = "";
        codeField4.text = "";
    }

    void Update()
    {
        
    }

    public void getKey(string _char)
    {
        //print("received key: " + _char);

        if(_char == "C")
        {
            codeField1.text = "";
            codeField2.text = "";
            codeField3.text = "";
            codeField4.text = "";
            inputCode = "";
            return;
        }

        if (codeField1.text == "")
        {
            codeField1.text = _char;
            inputCode += _char;

        }
        else if( codeField2.text == "")
        {
            codeField2.text = _char;
            inputCode += _char;
        }
        else if (codeField3.text == "")
        {
            codeField3.text = _char;
            inputCode += _char;
        }
        else if (codeField4.text == "")
        {
            codeField4.text = _char;
            inputCode += _char;
            checkCode();
        }
    }

    void checkCode()
    {
        
        print("CODE inputed:" + inputCode);

        if(inputCode == "1505")
        {
            print("CODE CORRECT");
            FindObjectOfType<audioManager>().Play("correctCode");
        }
        else
        {
            print("CODE INCORRECT");
            FindObjectOfType<audioManager>().Play("incorrectCode");
        }
    }
}
