using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study5 : MonoBehaviour
{
   
    void Start()
    {
        string userInput1 = "4"; //�г�
        string userInput2 = "70"; // ����
        

        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
        
        

        if (a >= 4)
        {
            if (b >= 70)
            {
                Debug.Log($"({a}�г� ) �հ��Դϴ�.");
            }
            else if (b < 70)
            {
                Debug.Log($"({a}�г� ) ���հ��Դϴ�.");
            }
            else if (b < 0) 
            {
                Debug.Log($"���");

            }
            else if (b > 100 )
            {
                Debug.Log($"���");
            }

        }
        if (a < 4)
        {
            if (b >= 60)
            {
                Debug.Log($"({a}�г� ) �հ��Դϴ�.");
            }
            else if (b < 60)
            {
                Debug.Log($"({a}�г� ���հ��Դϴ�.");
            }
            else if (b < 0)
            {
                Debug.Log($"���");

            }
            else if (b > 100)
            {
                Debug.Log($"���");
            }

        }
        
    }

    
}
