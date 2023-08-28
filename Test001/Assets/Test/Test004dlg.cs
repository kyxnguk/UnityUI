using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test004dlg : MonoBehaviour
{
    public Text txt_result = null;
    public InputField input = null;
    public Button btn_play = null;

    // Start is called before the first frame update
    void Start()
    {
        btn_play.onClick.AddListener(() =>
        {
            RamDa(int.Parse(input.text));
        });
    }

    public void RamDa(int a)
    {
        if (a < 0 && a > 10) return;

        int num = 1;
        int[] arr = new int[10];
        string str = "";
        for (int i = 1; i < a+1; i++)
        {
            num *= i;
            str += string.Format("{0}", i);
            if(i != a)
            {
                str += "*";
            }
        }

        txt_result.text = string.Format("{0} = {1}", str,num);
    }

 
}
