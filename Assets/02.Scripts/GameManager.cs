using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ����� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ����� ǥ���� �ؽ�Ʈ ������Ʈ

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
