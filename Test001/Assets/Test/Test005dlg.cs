using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test005dlg : MonoBehaviour
{
    public Text txt_result = null;
    public Button btn_play = null;
    public Button btn_clear = null;
    
    void Start()
    {
        btn_play.onClick.AddListener(() =>
        {
            //For();
            //While();
            //DoWhile();

            TestArray();
            FixArray();
        });
    }

    public void For()
    {
        int[] arr = new int[3] { 100, 200, 300 };

        txt_result.text += "[for문 테스트]\n";
        for (int i = 0; i < arr.Length; i++)
        {
            txt_result.text += string.Format("Temp[{0}] = {1},", i, arr[i]);
        }
        txt_result.text += "\n--------------------------------------------\n";
    }

    public void While()
    {
        int[] arr = new int[3] { 100, 200, 300 };
        int temp = 0;
        txt_result.text += "[While문 테스트]\n";
        while(temp < arr.Length)
        {
            txt_result.text += string.Format("Temp[{0}] = {1},", temp, arr[temp]);
            temp++;
        }
        txt_result.text += "\n--------------------------------------------\n";
    }

    public void DoWhile()
    {
        int[] arr = new int[3] { 100, 200, 300 };
        int temp = 0;
        txt_result.text += "[DoWhile문 테스트]\n";

        do
        {
            txt_result.text += string.Format("Temp[{0}] = {1},", temp, arr[temp]);
            temp++;
        } while (temp < arr.Length);

        txt_result.text += "\n--------------------------------------------";
    }

    public void TestArray()
    {
        int[,] arr = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        txt_result.text += "[2차원 배열]-----\n";
        PrintArray(arr);
        txt_result.text += "------------------\n";
    }

    public void FixArray()
    {
        int[,] arr = new int[2, 2] { { 6, 8 }, { 3, 4 } };
        PrintArray(arr);
    }

    public void PrintArray(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                txt_result.text += string.Format("arr[{0},{1}] = {2}\n", i, j, a[i, j]);
            }
        }

    }

}
