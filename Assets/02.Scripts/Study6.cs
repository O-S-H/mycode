using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study6 : MonoBehaviour
{
    
    void Start()
    {
        string Day = "7";
        
        switch(Day)
        {
            case "1":
                Debug.Log("1월은 31일 까지 있습니다.");
                    break;          
            case "2":
                Debug.Log("2월은 28일 까지 있습니다.");
                break;
            case "3":
                Debug.Log("3월은 31일 까지 있습니다.");
                break;
            case "4":
                Debug.Log("4월은 30일 까지 있습니다.");
                break;
            case "5":
                Debug.Log("5월은 31일 까지 있습니다.");
                break;
            case "6":
                Debug.Log("6월은 3일 까지 있습니다.");
                break;
            case "7":
                Debug.Log("7월은 31일 까지 있습니다.");
                break;
            case "8":
                Debug.Log("8월은 31일 까지 있습니다.");
                break;
            case "9":
                Debug.Log("1월은 31일 까지 있습니다.");
                break;
            case "10":
                Debug.Log("10월은 31일 까지 있습니다.");
                break;
            case "11":
                Debug.Log("11월은 30일 까지 있습니다.");
                break;
            case "12":
                Debug.Log("12월은 31일 까지 있습니다.");
                break;
            default:
                Debug.Log($"{Day}는(은) 존재하지 않는 달입니다.");
                break;

        }


    }

   
}
