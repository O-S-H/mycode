using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study4 : MonoBehaviour
{
  
    void Start()
    {
        string userInput = "33";

        int a = int.Parse(userInput);

        if (a % 3 == 0) 
        {
            Debug.Log($"{a}은 3의 배수입니다.");

        }
        else
        {
            Debug.Log($"{a}은 3의 배수가 아닙니다");

        }
    }

}
