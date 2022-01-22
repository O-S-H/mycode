using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study5 : MonoBehaviour
{
   
    void Start()
    {
        string userInput1 = "4"; //학년
        string userInput2 = "70"; // 점수
        

        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);
        
        

        if (a >= 4)
        {
            if (b >= 70)
            {
                Debug.Log($"({a}학년 ) 합격입니다.");
            }
            else if (b < 70)
            {
                Debug.Log($"({a}학년 ) 불합격입니다.");
            }
            else if (b < 0) 
            {
                Debug.Log($"경고");

            }
            else if (b > 100 )
            {
                Debug.Log($"경고");
            }

        }
        if (a < 4)
        {
            if (b >= 60)
            {
                Debug.Log($"({a}학년 ) 합격입니다.");
            }
            else if (b < 60)
            {
                Debug.Log($"({a}학년 불합격입니다.");
            }
            else if (b < 0)
            {
                Debug.Log($"경고");

            }
            else if (b > 100)
            {
                Debug.Log($"경고");
            }

        }
        
    }

    
}
