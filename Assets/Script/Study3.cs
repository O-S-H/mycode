using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "67";

        int a = int.Parse(userInput);

        if(a >= 50)
        {
            Debug.Log($"{a}�� 50�̻��Դϴ�.");

        }
        else
        {
            Debug.Log($"{a}�� 50�̸� �Դϴ�.");
        }
    }

    
}
