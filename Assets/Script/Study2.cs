using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "91";

        int a = int.Parse(userInput1);

        if (a >= 90) 
        {
            Debug.Log($"�л��� ������ : {a} = A");

        }
                  
           else if (a>=80) 
        {

            Debug.Log($"�л��� ������ : {a} = B");
        }
        else if (a >= 70)
        {

            Debug.Log($"�л��� ������ : {a} = C");
        }
        else
        {

            Debug.Log($"�л��� ������ : {a} = F");
        }

    }

   
}
