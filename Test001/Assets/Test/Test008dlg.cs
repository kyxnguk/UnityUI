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
        dic.Add(1, "���");
        dic.Add(2, "��");
        dic.Add(3, "����");
        txt_result.text += "\n[Dectionary-KeyValuePair]-----------\n";
        DicPrint();
    }
    void DicFix()
    {
        dic[1] = "���ִ� ���";
        dic[2] = "���ִ� ��";
        txt_result.text += "\n[�� ���� -key1,key2�� ����]-----------\n";
        DicPrint();
    }

    void DicResult()
    {
        dic.Remove(1);
        txt_result.text += "\n[���� - Key:1����]----------------------\n";
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
