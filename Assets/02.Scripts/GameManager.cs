using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // 게임오버시 활성화할 텍스트 게임 오브젝트
    public Text timeText; //생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText; // 최고기록을 표시할 텍스트 컴포넌트

    private float surviceTime;
    private bool isGameover;

   
    void Start()
    {
        surviceTime = 0;
        isGameover = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndGame()
    {

    }
}
