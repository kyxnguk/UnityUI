using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test002dlg : MonoBehaviour
{
    public InputField input = null;
    public Text txt = null;
    public Button btn1 = null;
    public Button btn2 = null;

    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        btn1.onClick.AddListener(() =>
        {
            //Score1();

            Score2();
        });
    }

    void Score1()
    {
        if(int.Parse(input.text) >= 90)
        {
            txt.text = "A";
        }
        else if(int.Parse(input.text) >= 80)
        {
            txt.text = "B";
        }
        else if (int.Parse(input.text) >= 70)
        {
            txt.text = "C";
        }
        else if (int.Parse(input.text) >= 60)
        {
            txt.text = "D";
        }
        else 
        {
            txt.text = "F";
        }
    }

    void Score2()
    {
        switch (int.Parse(input.text)/10)
        {
            case 10:
                    txt.text = "A";
                break;
            case 9:
                txt.text = "B";
                break;
            case 8:
                txt.text = "C";
                break;
            case 7:
                txt.text = "D";
                break;
            default:
                txt.text = "F";
                break;
        }
    }


}



