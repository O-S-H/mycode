using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study7 : MonoBehaviour
{
    
    void Start()
    {
        string userInput1 = "3";
        string userInput2 = "34.2";

        int a = int.Parse(userInput1);
        float b = float.Parse(userInput2);

        Debug.Log($"3 �� ������ {x(a)}�Դϴ�.");
        Debug.Log($"34.2�� ��������{y(b)}�Դϴ�.");

       


    }
    int x (int a)
    {


        return a * a;

    }
    float y (float b)
    {


        return b * b;

    }


}
