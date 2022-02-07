using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "3";
        string userInput2 = "15";
        string userInput3 = "-";
        
        
            
        int a = int.Parse(userInput1);
        int b = int.Parse(userInput2);

       switch(userInput3)
        {
            case "+":
                Debug.Log($"+ : {a + b}");
                break;
            case "*":
                Debug.Log($"+ : {a * b}");
                break;
            case "/":
                Debug.Log($"+ : {a / b}");
                break;
            case "-":
                Debug.Log($"- : {a - b}");
                break;
        }
            
            


    }


}
