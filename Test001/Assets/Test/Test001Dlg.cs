using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour
{
    public Text txt_testresult = null;
    public Button btn_ok = null;
    public Button btn_clear = null;

    public int x = 100;
    public int y = 200;

    void Start()
    {
         Initialize(); 
    }

    void Initialize()
    {
        btn_ok.onClick.AddListener(() =>
        {
            txt_testresult.text = string.Format("x = {0} , y = {1}\n", x, y);
            txt_testresult.text += string.Format("{0} + {1} = {2}\n", x, y, Sum(x, y));
            Swap1(x,y);
            txt_testresult.text += string.Format("x = {0} , y = {1}\n", x, y);
            Swap2(ref x, ref y);
            txt_testresult.text += string.Format("x = {0} , y = {1}\n", x, y);
        });


        btn_clear.onClick.AddListener(() =>
        {
            txt_testresult.text = " ";
        });

    }



    int Sum(int a , int b)
    {
        int c = a + b;
        return c;
    }

    void Swap1(int a, int b)
    {
        int c = a;
        a = b;
        b = c;
    }

    void Swap2(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }



}
