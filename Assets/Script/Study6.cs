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
                Debug.Log("1���� 31�� ���� �ֽ��ϴ�.");
                    break;          
            case "2":
                Debug.Log("2���� 28�� ���� �ֽ��ϴ�.");
                break;
            case "3":
                Debug.Log("3���� 31�� ���� �ֽ��ϴ�.");
                break;
            case "4":
                Debug.Log("4���� 30�� ���� �ֽ��ϴ�.");
                break;
            case "5":
                Debug.Log("5���� 31�� ���� �ֽ��ϴ�.");
                break;
            case "6":
                Debug.Log("6���� 3�� ���� �ֽ��ϴ�.");
                break;
            case "7":
                Debug.Log("7���� 31�� ���� �ֽ��ϴ�.");
                break;
            case "8":
                Debug.Log("8���� 31�� ���� �ֽ��ϴ�.");
                break;
            case "9":
                Debug.Log("1���� 31�� ���� �ֽ��ϴ�.");
                break;
            case "10":
                Debug.Log("10���� 31�� ���� �ֽ��ϴ�.");
                break;
            case "11":
                Debug.Log("11���� 30�� ���� �ֽ��ϴ�.");
                break;
            case "12":
                Debug.Log("12���� 31�� ���� �ֽ��ϴ�.");
                break;
            default:
                Debug.Log($"{Day}��(��) �������� �ʴ� ���Դϴ�.");
                break;

        }


    }

   
}