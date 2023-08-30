using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test007dlg : MonoBehaviour
{
    public Button btn_add = null;
    public Button btn_clear = null;
    public Button btn_play = null;
    public Text txt_result = null;
    public InputField input = null;

    List<int> a = new List<int>();

    void Start()
    {
        btn_add.onClick.AddListener(() =>
        {
            AddList();
        });

        btn_play.onClick.AddListener(() =>
        {
            SortList();
        });

        btn_clear.onClick.AddListener(() =>
        {
            txt_result.text = "";
        });
    }

    public void AddList()
    {
        if (int.Parse(input.text) >= 0 && int.Parse(input.text) <= 100)
        {
            if(a.Count >= 5)
            {
                return;
            }
            a.Add(int.Parse(input.text));
            txt_result.text += int.Parse(input.text) + ",";
        }
    }

    public void SortList()
    {
        a.Sort();
        txt_result.text += "\n\n";
        for (int i = 0; i < a.Count; i++)
        {
            txt_result.text += a[i] + ",";
        }
    }

}
