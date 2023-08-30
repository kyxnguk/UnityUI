using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test006Dlg : MonoBehaviour
{
    public Text txt_result = null;
    public Button btn_play = null;
    public Button btn_clear = null;

    void Start()
    {
        btn_play.onClick.AddListener(() =>
        {
            ListFor();
            ListForeach();
            ListRemove();
        });
    }

    public void ListFor()
    {
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);

        txt_result.text += "[List:for문]------------\n"; 
        for (int i = 0; i < list.Count; i++)
        {
            txt_result.text += string.Format("[{0}] : {1},", i, list[i]);
        }
        txt_result.text += "\n----------------------\n";
    }

    public void ListForeach()
    {
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        txt_result.text += "[List:foreach문]------------\n";
        PrintList(list);
    }

    public void ListRemove()
    {
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        list.Remove(10);
        list.Remove(40);

        txt_result.text += "\n[리스트삭제 - foreach]------------\n";
        PrintList(list);
        txt_result.text += "\n----------------------\n";
    }

    public void PrintList(List<int> b)
    {
        foreach (int a in b)
        {
            txt_result.text += string.Format("{0},", a);
        }
    }

}
