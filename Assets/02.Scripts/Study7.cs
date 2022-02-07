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

        Debug.Log($"3 의 제곱은 {x(a)}입니다.");
        Debug.Log($"34.2의 제곱값은{y(b)}입니다.");

       


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
