using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test003dlg : MonoBehaviour
{
    public Text txt_result = null;
    public InputField input1 = null;
    public InputField input2 = null;
    public InputField input3 = null;
    public Button btn_play = null;
    public Button btn_clear = null;

    void Start()
    {
        btn_play.onClick.AddListener(() =>
        {
            //Check(int.Parse(input1.text), int.Parse(input2.text), int.Parse(input3.text));

            int[] arr = new int[3] { int.Parse(input1.text), int.Parse(input2.text), int.Parse(input3.text) };
            Check2(arr);
        });

        btn_clear.onClick.AddListener(() =>
        {
            txt_result.text = "";
        });
    }

    public void Check(int a,int b, int c)
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0; 

        if (a >= 0 && a <=100 && b >= 0 && b <= 100 && c >= 0 && c <= 100  )
        {
            if (a > b && a > c)
            {
                if (c > b) Swap(ref b, ref c);
            }
            else if (b > a && b > c)
            {
                Swap(ref a, ref b);
                if (c > b) Swap(ref b, ref c);
            }
            else if (c > b && c > a)
            {
                Swap(ref a, ref c);
                if (c > b) Swap(ref b, ref c);
            }

            txt_result.text = string.Format("{0} {1} {2}", a, b, c);
        }
    }

    public void Swap(ref int a,ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }

    public void Check2(int[] a)
    {

        if (!(a[0] >= 0 && a[0] <= 100 && a[1] >= 0 && a[1] <= 100 && a[2] >= 0 && a[2] <= 100)) return ;
        

        for (int j =0; j < a.Length-1; j++)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[j]) Swap(ref a[i], ref a[j]);
            }
        }

          txt_result.text = string.Format("{0} {1} {2}", a[0], a[1], a[2]);
        }

    
}
