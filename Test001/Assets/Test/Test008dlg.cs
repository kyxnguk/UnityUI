using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test008dlg : MonoBehaviour
{
    public Text txt_result = null;
    public Button btn_play = null;
    public Button btn_clear = null;

    Dictionary<int, string> dic = new Dictionary<int, string>();

    void Start()
    {
        btn_play.onClick.AddListener(() =>
        {
            Dic();
            DicFix();
            DicResult();
        });

    }

    void Dic()
    {
        dic.Add(1, "사과");
        dic.Add(2, "배");
        dic.Add(3, "수박");
        txt_result.text += "\n[Dectionary-KeyValuePair]-----------\n";
        DicPrint();
    }
    void DicFix()
    {
        dic[1] = "맛있는 사과";
        dic[2] = "맛있는 배";
        txt_result.text += "\n[값 변경 -key1,key2값 변경]-----------\n";
        DicPrint();
    }

    void DicResult()
    {
        dic.Remove(1);
        txt_result.text += "\n[삭제 - Key:1삭제]----------------------\n";
        DicPrint();
    }


    void DicPrint()
    {
        foreach(KeyValuePair<int,string> ddd in dic)
        {
            txt_result.text += string.Format("{0} : {1},", ddd.Key, ddd.Value);
        }
    }

}
